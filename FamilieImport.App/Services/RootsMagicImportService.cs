using FamilieImport.RootsMagic.Models;
using ImportLegacy.RootsMagic.Repositories;
using System.Collections.Generic;
using System.Data;

namespace FamilieImport.App.Services
{
    public class RootsMagicImportService : BaseImportService
    {
        private RootsMagicRepository RootsMagic { get; }

        public RootsMagicImportService(IDbConnection dbConnection)
        {
            RootsMagic = new RootsMagicRepository(dbConnection);
        }

        public IEnumerable<RootsMagicPerson> GetPersons()
        {
            return RootsMagic.GetPersons();
        }
    }
}
