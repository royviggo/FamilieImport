using FamilieImport.Domain.Models;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Dapper.Contrib.Extensions;

namespace FamilieImport.Domain.Data
{
    public class ImportRepository
    {
        private IDbConnection DbConnection { get; }

        public ImportRepository(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }

        public int AddData(ImportData data)
        {
            return (int)DbConnection.Insert(data);
        }

        public int AddData(IEnumerable<ImportData> data)
        {
            var inserted = 0;
            DbConnection.Open();

            using (var transaction = DbConnection.BeginTransaction())
            {
                try
                {
                    var sql = "INSERT INTO ImportDatas (LogId, ItemTypeId, ItemId, CheckSum, Data) VALUES (@LogId, @ItemTypeId, @ItemId, @CheckSum, @Data)";
                    inserted = DbConnection.Execute(sql, data, transaction: transaction);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }

            DbConnection.Close();
            return inserted;
        }

        public int AddLog(ImportLog log)
        {
            return (int)DbConnection.Insert(log);
        }

        public ImportSource GetSource(int id)
        {
            return DbConnection.QuerySingle<ImportSource>("SELECT * FROM ImportSources WHERE Id = @Id", param: new { Id = id });
        }

        public ImportSourceType GetSourceType(int id)
        {
            return DbConnection.QuerySingle<ImportSourceType>("SELECT * FROM ImportSourceTypes WHERE Id = @Id", param: new { Id = id });
        }

        public IEnumerable<ImportItemType> GetItemTypes(int sourceTypeId)
        {
            return DbConnection.Query<ImportItemType>("SELECT * FROM ImportItemTypes WHERE SourceTypeId = @SourceTypeId", param: new { SourceTypeId = sourceTypeId });
        }

        public ImportData GetLatestData(int sourceId, int itemTypeId, string itemId)
        {
            return DbConnection.QuerySingleOrDefault<ImportData>(
                "SELECT d.* FROM ImportDatas d " +
                "INNER JOIN ImportLogs l on d.LogId = l.Id " +
                "WHERE l.SourceId = @SourceId AND d.ItemTypeId = @ItemTypeId AND d.ItemId = @ItemId " +
                "ORDER BY l.Imported DESC LIMIT 1", 
                param: new { SourceId = sourceId, ItemTypeId = itemTypeId, ItemId = itemId });
        }
    }
}
