using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using NLog;

namespace PE_Tools
{
    public class Database
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public List<string> Databases { get; set; }
        private async Task<List<string>> GetDatabasesAsync()
        {
            Databases = new List<string>();
            string ConnectionString = ConfigurationManager.AppSettings["databaseConnectionString"];
            if (string.IsNullOrEmpty(ConnectionString))
            {
                Logger.Error("Database connection string not found in app settings.");
                throw new ConfigurationErrorsException("Database connection string not found in app settings.");
            }
            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                await con.OpenAsync();
                using(SqlCommand command = new SqlCommand("select name from sys.databases", con))
                {
                    using (IDataReader dr = await command.ExecuteReaderAsync())
                    { 
                        while(dr.Read())
                        {
                            Databases.Add(dr[0].ToString());
                        }
                    }                 
                }
            }
            return Databases;
        }

        public async Task<List<string>> GetSelectedDatabasesAsync(string suffix)
        {
            if(Databases == null)
            {
                Databases = await GetDatabasesAsync();
            }
            var ret = new List<string>() { "select" };
            ret.AddRange(Databases.Where(s => s.Contains(suffix)).ToList());
            return ret;
        }
    }
}
