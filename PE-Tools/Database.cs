using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PE_Tools
{
    public class Database
    {
        public List<string> Databases { get; set; }
        private List<string> GetDatabases()
        {
            Databases = new List<string>();
            string ConnectionString = @"server = (local)\SQLEXPRESS; Integrated Security = True; Pooling = True;";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using(SqlCommand command = new SqlCommand("select name from sys.databases", con))
                {
                    using (IDataReader dr = command.ExecuteReader())
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

        public List<string> GetSelectedDatabases(string suffix)
        {
            if(Databases == null)
            {
                GetDatabases();
            }
            return Databases.Where(s => s.EndsWith(suffix)).ToList();
        }
    }
}
