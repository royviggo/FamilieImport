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

            var rootsMagicConnectionString = @"Data Source=C:\source\FamilieImport\DataFiles\RootsMagicData.rmgc";
            var importConnectionString = @"Data Source=C:\source\FamilieImport\DataFiles\FamilieImport.db";

            var rootsMagicConnection = new SqliteConnection(rootsMagicConnectionString);
            var importConnection = new SqliteConnection(importConnectionString);

            var rootsMagicImportService = new RootsMagicImportService(rootsMagicConnection, importConnection);

            rootsMagicImportService.Import();

            //Console.WriteLine("Persons");

            //foreach (var p in rootsMagicImportService.GetPersons())
            //{
            //    Console.WriteLine("{0}, {1}, {2}, {3}", p.PersonID, p.Sex, p.Living, p.Note);
            //}

            Console.ReadLine();
        }
    }
}
