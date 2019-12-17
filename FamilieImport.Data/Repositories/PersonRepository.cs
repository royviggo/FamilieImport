using System.Collections.Generic;
using System.Data;
using Dapper;
using ImportLegacy.Data.Utils;
using ImportLegacy.Data.Interfaces;
using ImportLegacy.Legacy.Models;
using ImportLegacy.Data.Repositories;

namespace ImportLegacy.Data.Repositories
{
    public class PersonRepository : GenericRepository<LegacyIR>
    {
        public PersonRepository(IDbConnection dbFactory) : base(dbFactory)
        {
        }

        public override LegacyIR Get(int id)
        {
            var sql = GetBaseQuery().Where("Id = @Id");

            return Db.QuerySingle<LegacyIR>(sql, param: new { Id = id });
        }

        public override IEnumerable<LegacyIR> GetAll()
        {
            var sql = GetBaseQuery();

            return Db.Query<LegacyIR>(sql, param: new { });
        }

        public override string GetBaseQuery()
        {
            return @"
                SELECT *
                FROM   tblIR
                ";
        }
    }
}
