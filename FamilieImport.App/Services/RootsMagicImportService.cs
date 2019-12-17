using Dapper;
using FamilieImport.RootsMagic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FamilieImport.App.Services
{
    public class RootsMagicImportService : BaseImportService
    {
        private IDbConnection DbConnection { get; }

        public RootsMagicImportService(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }

        public IEnumerable<RootsMagicPerson> GetPersons()
        {
            return DbConnection.Query<RootsMagicPerson>("SELECT * FROM PersonTable", param: new { });
        }

    }
}
