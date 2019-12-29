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
using Microsoft.Extensions.Logging;

namespace FamilieImport.App.Services
{
    public partial class RootsMagicImportService : BaseImportService
    {
        private RootsMagicRepository RootsMagic { get; }
        private ImportRepository ImportRepository { get; }
        private ILogger Logger { get; }
        private readonly int rootsmagicSourceId = 1;

        public RootsMagicImportService(IDbConnection dbData, IDbConnection dbImport, ILogger logger)
        {
            RootsMagic = new RootsMagicRepository(dbData);
            ImportRepository = new ImportRepository(dbImport);
            Logger = logger;
       }

        public IEnumerable<RootsMagicPerson> GetPersons()
        {
            return RootsMagic.GetPersons();
        }

        public void Import()
        {
            Logger.LogInformation("Starting import");
            var stopwatch = Stopwatch.StartNew();

            // Get Import Source
            var source = ImportRepository.GetSource(rootsmagicSourceId);

            // Get Source Type
            //var sourceType = ImportRep.GetSourceType(source.SourceTypeId);

            // Create log
            var logId = ImportRepository.AddLog(new ImportLog
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
            Logger.LogInformation("Elapsed time: {0}", stopwatch.Elapsed.ToString(@"mm\:ss\.fff"));
        }

        private void SaveData<T>(int logId, IEnumerable<T> importList) where T : IImportEntity
        {
            using var sha1 = new SHA1Managed();
            var dataList = new List<ImportData>();

            foreach (var item in importList)
            {
                var jsonData = item.ToJsonData();
                var checkSum = sha1.ComputeHash(Encoding.UTF8.GetBytes(jsonData)).ToHexString();
                var dataExists = ImportRepository.GetLatestData(rootsmagicSourceId, item.ItemType, item.ItemId);

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

            var insertedRows = ImportRepository.AddData(dataList);

            Logger.LogInformation("Importing {0}... {1}", typeof(T).Name, insertedRows);
        }
    }
}
