using FamilieImport.Domain.Extensions;
using FamilieImport.Domain;
using FamilieImport.Domain.Data;
using FamilieImport.Domain.Models;
using FamilieImport.RootsMagic.Models;
using ImportLegacy.RootsMagic.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace FamilieImport.App.Services
{
    public partial class RootsMagicImportService : BaseImportService
    {
        private RootsMagicRepository RootsMagic { get; }
        private ImportRepository ImportRep { get; }
        private readonly int rootsmagicSourceId = 1;

        public RootsMagicImportService(IDbConnection dbData, IDbConnection dbImport)
        {
            RootsMagic = new RootsMagicRepository(dbData);
            ImportRep = new ImportRepository(dbImport);
        }

        public IEnumerable<RootsMagicPerson> GetPersons()
        {
            return RootsMagic.GetPersons();
        }

        public void Import()
        {
            Console.WriteLine("Starting import");
            var stopwatch = Stopwatch.StartNew();

            // Get Import Source
            var source = ImportRep.GetSource(rootsmagicSourceId);

            // Get Source Type
            //var sourceType = ImportRep.GetSourceType(source.SourceTypeId);

            // Create log
            var logId = ImportRep.AddLog(new ImportLog
            {
                SourceId = source.Id,
                Imported = DateTime.UtcNow,
                Status = 0,
            });

            SaveData(logId, RootsMagic.GetChildren());
            SaveData(logId, RootsMagic.GetCitations());
            SaveData(logId, RootsMagic.GetEvents());
            SaveData(logId, RootsMagic.GetFactTypes());
            SaveData(logId, RootsMagic.GetFamilies());
            SaveData(logId, RootsMagic.GetMediaLinks());
            SaveData(logId, RootsMagic.GetMultimedia());
            SaveData(logId, RootsMagic.GetNames());
            SaveData(logId, RootsMagic.GetPersons());
            SaveData(logId, RootsMagic.GetPlaces());
            SaveData(logId, RootsMagic.GetRoles());
            SaveData(logId, RootsMagic.GetSources());
            SaveData(logId, RootsMagic.GetSourceTemplates());
            SaveData(logId, RootsMagic.GetUrls());
            SaveData(logId, RootsMagic.GetWitnesses());

            stopwatch.Stop();
            Console.WriteLine("Elapsed time: {0}", stopwatch.Elapsed.ToString(@"mm\:ss\.fff"));
        }

        private void SaveData<T>(int logId, IEnumerable<T> importList) where T : IImportEntity
        {
            using var sha1 = new SHA1Managed();
            Console.Write("Importing {0} ... ", typeof(T).Name);
            var dataList = new List<ImportData>();

            foreach (var item in importList)
            {
                var jsonData = item.ToJsonData();
                var checkSum = sha1.ComputeHash(Encoding.UTF8.GetBytes(jsonData)).ToHexString();
                var dataExists = ImportRep.GetLatestData(rootsmagicSourceId, item.ItemType, item.ItemId);

                if (dataExists?.CheckSum == checkSum) continue;

                dataList.Add(new ImportData
                {
                    LogId = logId,
                    ItemTypeId = item.ItemType,
                    ItemId = item.ItemId,
                    Data = jsonData,
                    CheckSum = checkSum,
                });
            }

            var insertedRows = ImportRep.AddData(dataList);

            Console.WriteLine("{0}", insertedRows);
        }
    }
}
