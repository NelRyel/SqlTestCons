using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestCons
{
    internal class _CreateDB
    {
        public async Task CreateDbAsync()
        {
            using (SqlConnection connection = new SqlConnection(__connect.getStringConnectMaster()))
            {
                await connection.OpenAsync();
                Console.WriteLine("opened 1__________");

                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE DATABASE sqlgamedb";
                command.Connection = connection;
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("created! ");


                //Console.WriteLine(connection.ClientConnectionId);

                //Console.WriteLine("Свойства подключения:");
                //Console.WriteLine($"\tСтрока подключения: {connection.ConnectionString}");
                //Console.WriteLine($"\tБаза данных: {connection.Database}");
                //Console.WriteLine($"\tСервер: {connection.DataSource}");
                //Console.WriteLine($"\tВерсия сервера: {connection.ServerVersion}");
                //Console.WriteLine($"\tСостояние: {connection.State}");
                //Console.WriteLine($"\tWorkstationld: {connection.WorkstationId}");

            }
        }



    }
}
