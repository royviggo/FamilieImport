using FamilieImport.App.Services;
using FamilieImport.Gedcom;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Data.Odbc;
using System.IO;

namespace ImportLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var logger = LoggerFactory.Create(builder => builder.AddConsole())
            //    .CreateLogger<RootsMagicImportService>();

            //var legacyFilename = @"C:\source\FamilieImport\DataFiles\LegacyData.fdb";
            //var legacyConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + legacyFilename + ";Uid=admin;Pwd=;";
            ////var legacyConnection = new OdbcConnection(legacyConnectionString);

            //var rootsMagicConnectionString = @"Data Source=C:\source\FamilieImport\DataFiles\RootsMagicData.rmgc";
            //var importConnectionString = @"Data Source=C:\source\FamilieImport\DataFiles\FamilieImport.db";

            //var rootsMagicConnection = new SqliteConnection(rootsMagicConnectionString);
            //var importConnection = new SqliteConnection(importConnectionString);

            //var rootsMagicImportService = new RootsMagicImportService(rootsMagicConnection, importConnection, logger);
            //rootsMagicImportService.Import();

            var gedcomFilename = @"C:\source\FamilieImport\DataFiles\LincolnFamily.ged";

            try
            {
                using var sr = new StreamReader(gedcomFilename);
                var gedComReader = new GedcomReader(sr);

                foreach (var gedComLine in gedComReader.Read())
                    Console.WriteLine(gedComLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
