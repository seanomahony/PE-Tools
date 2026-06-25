using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using NLog;

namespace PE_Tools
{
    public class Database
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly SemaphoreSlim _databasesLock = new SemaphoreSlim(1, 1);
        private IReadOnlyList<string>? _databases;

        private async Task<IReadOnlyList<string>> LoadDatabasesAsync()
        {
            var databases = new List<string>();

            string? connectionString = SettingsManager.GetDatabaseConnectionString();
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                Logger.Warn("Database connection string not found. Returning empty database list.");
                return databases;
            }

            try
            {
                var builder = new SqlConnectionStringBuilder(connectionString);
                if (string.IsNullOrWhiteSpace(builder.DataSource))
                {
                    Logger.Warn("Database connection string does not contain a server name. Returning empty database list.");
                    return databases;
                }

                int connectTimeoutSeconds = SettingsManager.GetDatabaseConnectTimeout();
                builder.ConnectTimeout = connectTimeoutSeconds;

                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(connectTimeoutSeconds)))
                    {
                        try
                        {
                            await con.OpenAsync(cts.Token);
                        }
                        catch (OperationCanceledException ex)
                        {
                            Logger.Warn(ex, "Opening database connection timed out. Returning empty database list.");
                            return databases.ToArray();
                        }
                    }

                    using (SqlCommand command = new SqlCommand("select name from sys.databases", con))
                    {
                        using (SqlDataReader dr = await command.ExecuteReaderAsync())
                        {
                            while (dr.Read())
                            {
                                string? dbName = dr[0]?.ToString();
                                if (!string.IsNullOrWhiteSpace(dbName))
                                {
                                    databases.Add(dbName);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Logger.Warn(ex, "Database connection is not available yet. Returning empty database list.");
            }
            catch (ArgumentException ex)
            {
                Logger.Warn(ex, "Database connection string is invalid. Returning empty database list.");
            }

            return databases.ToArray();
        }

        private async Task<IReadOnlyList<string>> GetDatabasesAsync()
        {
            if (_databases != null)
            {
                return _databases;
            }

            await _databasesLock.WaitAsync();
            try
            {
                if (_databases == null)
                {
                    _databases = await LoadDatabasesAsync();
                }

                return _databases;
            }
            finally
            {
                _databasesLock.Release();
            }
        }

        public async Task<List<string>> GetSelectedDatabasesAsync(string suffix)
        {
            IReadOnlyList<string> databases = await GetDatabasesAsync();

            var ret = new List<string>() { "select" };
            ret.AddRange(databases.Where(s => s.Contains(suffix)).ToList());
            return ret;
        }
    }
}
