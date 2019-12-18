using FamilieImport.RootsMagic.Models;
using ImportLegacy.RootsMagic.Repositories;
using System.Collections.Generic;
using System.Data;

namespace FamilieImport.App.Services
{
    public class RootsMagicImportService : BaseImportService
    {
        private RootsMagicRepository _rootsMagicRepository;

        public RootsMagicImportService(IDbConnection dbConnection)
        {
            _rootsMagicRepository = new RootsMagicRepository(dbConnection);
        }

        public IEnumerable<RootsMagicPerson> GetPersons()
        {
            return _rootsMagicRepository.GetPersons();
        }
    }
}
