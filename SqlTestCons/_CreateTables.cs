using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestCons
{
    internal class _CreateTables
    {
        public async Task CreateTableGame()
        {
            using (SqlConnection connection = new SqlConnection(__connect.getStringConnectCreated()))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE TABLE Games (Id INT PRIMARY KEY INDENTITY, Name NVARCHAR(100) NOT NULL, Description NVARCHAR(1000)) ";
                command.Connection = connection;
                await command.ExecuteNonQueryAsync();
                await Console.Out.WriteLineAsync(   "Table Created");

            }

        }
    }
}
