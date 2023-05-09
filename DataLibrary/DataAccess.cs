using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            // Call to MySQL
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                // Gets a list of rows that are of a certian type <T>.
                var rows = await connection.QueryAsync<T>(sqlStatement, parameters);
                return rows.ToList();
            }
        }

        public async Task<int> SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rowCount = await connection.ExecuteAsync(sqlStatement, parameters);
                return rowCount;
            }
        }

    }
}
