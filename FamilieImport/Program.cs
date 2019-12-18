using FamilieImport.App.Services;
using Microsoft.Data.Sqlite;
using System;
using System.Data.Odbc;

namespace ImportLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            var legacyFilename = @"C:\source\FamilieImport\Data\LegacyData.fdb";
            var legacyConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + legacyFilename + ";Uid=admin;Pwd=;";
            //var legacyConnection = new OdbcConnection(legacyConnectionString);

            var rootsMagicConnectionString = @"Data Source=C:\source\FamilieImport\Data\RootsMagicData.rmgc";
            var rootsMagicConnection = new SqliteConnection(rootsMagicConnectionString);

            var rootsMagicImportService = new RootsMagicImportService(rootsMagicConnection);

            Console.WriteLine("Persons");

            foreach (var p in rootsMagicImportService.GetPersons())
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", p.PersonID, p.Sex, p.Living, p.Note);
            }

            Console.ReadLine();
        }
    }
}
