using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestCons
{



    public static class __connect
    {
        static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True";

        public static string getStringConnectMaster()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True";
            return connectionString;
        }
        public static string getStringConnectCreated()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=sqlgamedb;Trusted_Connection=True";
            return connectionString;
        }
    }
}
