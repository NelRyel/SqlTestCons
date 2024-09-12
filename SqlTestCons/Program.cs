// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SqlTestCons;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

Console.WriteLine("Hello, World!");



//SqlConnection connection = new SqlConnection(connect.getStringConnect());

//try
//{
//    await connection.OpenAsync();
//    Console.WriteLine(  "opened connect");
//}
//catch(SqlException ex)
//{
//    Console.WriteLine( ex.Message);
//}
//finally
//{
//    if(connection.State == ConnectionState.Open)
//    {
//        await connection.CloseAsync();
//        Console.WriteLine(  "closed____ ");
//    }
//}
//Console.WriteLine( "END");
//Console.Read();

//через юзинг
//SqlConnection connection = new SqlConnection(__connect.getStringConnect());
_CreateTables createTables = new _CreateTables();
createTables.CreateTableGame.;


using (SqlConnection connection = new SqlConnection(__connect.getStringConnectCreated()))
{
    await connection.OpenAsync();
    Console.WriteLine( "opened 1__________");

    //await connection.OpenAsync();
    //SqlCommand command = new SqlCommand();
    //command.CommandText = "CREATE TABLE Games (Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(100) NOT NULL) ";
    //command.Connection = connection;
    //await command.ExecuteNonQueryAsync();
    //Console.WriteLine("CREATED TABLE");

    //Console.WriteLine(connection.ClientConnectionId);

    //Console.WriteLine("Свойства подключения:");
    Console.WriteLine($"\tСтрока подключения: {connection.ConnectionString}");
    Console.WriteLine($"\tБаза данных: {connection.Database}");
    //Console.WriteLine($"\tСервер: {connection.DataSource}");
    //Console.WriteLine($"\tВерсия сервера: {connection.ServerVersion}");
    //Console.WriteLine($"\tСостояние: {connection.State}");
    //Console.WriteLine($"\tWorkstationld: {connection.WorkstationId}");

}



Console.WriteLine("ЗА ЮЗИНГОМ__________________________");
//Console.WriteLine(connection.State.ToString());
Console.Read();