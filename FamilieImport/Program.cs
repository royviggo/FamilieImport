using Microsoft.Data.Sqlite;
using System;
using System.Data.Odbc;

namespace ImportLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filename = @"C:\source\ImportLegacy\ImportLegacy\LegacyData.accdb";
            //var filename = @"C:\source\ImportLegacy\ImportLegacy\Database1.accdb";
            //var legacyConnectionString = Settings.LegacyConnectionString(filename);
            //var legacyConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + filename + ";Uid=admin;Pwd=;";
            //var legacyConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dsn=Database1;";
            //var connection = new OdbcConnection(legacyConnectionString);

            //Pedersen-Karlsen.rmgc
            var rootsMagicConnectionString = @"Data Source=C:\source\FamilieImport\Data\Pedersen-Karlsen.rmgc";
            var connection = new SqliteConnection(rootsMagicConnectionString);
            
            //using (var unitOfWork = new UnitOfWork(connection))
            //{
            //    Console.WriteLine("Places");

            //    var persons = unitOfWork.Persons.GetAll();
            //    foreach (var p in persons)
            //    {
            //        Console.WriteLine("{0} - {1} - {2}, {3}", p.ID, p.IDIR, p.Surname, p.GivenName);
            //    }

            //}

            Console.ReadLine();
        }
    }
}
