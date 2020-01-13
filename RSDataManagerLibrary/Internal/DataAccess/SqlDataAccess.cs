using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDataManager.Library.Internal.DataAccess
{
    // This class uses Dapper - a Micro ORM
    // Dapper is used instead of EF
    // https://dapper-tutorial.net/
    internal class SqlDataAccess
    {
        public string GetConnectionString(string connectionStringName)
        {
            return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }


        // TODO: make async
        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>
                    (
                    storedProcedure, 
                    parameters, 
                    commandType: CommandType.StoredProcedure
                    ).ToList();

                return rows;
            }
        }

        // TODO: make async
        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

    }
}
