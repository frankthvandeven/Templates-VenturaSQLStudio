using ConsoleApp.VenturaAutoCreate;
using System;
using System.Data.SqlClient;
using VenturaSQL;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Server=tcp:sysdev-sqlserver-public.database.windows.net,1433;Initial Catalog=AdventureWorks2017;Persist Security Info=False;User ID=reader;Password=easypassword9!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=90;";

            VenturaSqlConfig.DefaultConnector = new AdoConnector(SqlClientFactory.Instance, cs);

            GetAll_Person_Person_Recordset rs = new();
            rs.RowLimit = 50;

            string key = "R";

            while( key.ToUpper() != "Q")
            {

                Console.WriteLine();
                Console.WriteLine("Sending request to Azure SQL...");

                rs.ExecSql();

                Console.WriteLine("Response received.");

                foreach (var record in rs)
                    Console.WriteLine($" {record.FirstName} Hello World!");

                Console.WriteLine();
                Console.WriteLine("Press Q to quit.");
                Console.WriteLine("Any other key to run again.");

                key = Console.ReadKey().KeyChar.ToString().ToUpper();
            } 

        }
    }
}
