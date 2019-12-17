using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FamilieImport.App.Services
{
    public class RootsMagicImportService : BaseImportService
    {
        private readonly IDbConnection _dbConnection;

        public RootsMagicImportService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
