using Dapper;
using FamilieImport.RootsMagic.Models;
using System.Collections.Generic;
using System.Data;

namespace FamilieImport.RootsMagic.Repositories
{
    public class RootsMagicRepository
    {
        private IDbConnection DbConnection { get; }

        public RootsMagicRepository(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }

        public IEnumerable<RootsMagicChild> GetChildren()
        {
            return DbConnection.Query<RootsMagicChild>("SELECT * FROM ChildTable", param: new { });
        }

        public IEnumerable<RootsMagicCitation> GetCitations()
        {
            return DbConnection.Query<RootsMagicCitation>("SELECT * FROM CitationTable", param: new { });
        }

        public IEnumerable<RootsMagicEvent> GetEvents()
        {
            return DbConnection.Query<RootsMagicEvent>("SELECT * FROM EventTable", param: new { });
        }

        public IEnumerable<RootsMagicFactType> GetFactTypes()
        {
            return DbConnection.Query<RootsMagicFactType>("SELECT * FROM FactTypeTable", param: new { });
        }

        public IEnumerable<RootsMagicFamily> GetFamilies()
        {
            return DbConnection.Query<RootsMagicFamily>("SELECT * FROM FamilyTable", param: new { });
        }

        public IEnumerable<RootsMagicMediaLink> GetMediaLinks()
        {
            return DbConnection.Query<RootsMagicMediaLink>("SELECT * FROM MediaLinkTable", param: new { });
        }

        public IEnumerable<RootsMagicMultimedia> GetMultimedia()
        {
            return DbConnection.Query<RootsMagicMultimedia>("SELECT * FROM MultimediaTable", param: new { });
        }

        public IEnumerable<RootsMagicName> GetNames()
        {
            return DbConnection.Query<RootsMagicName>("SELECT * FROM NameTable", param: new { });
        }

        public IEnumerable<RootsMagicPerson> GetPersons()
        {
            return DbConnection.Query<RootsMagicPerson>("SELECT * FROM PersonTable", param: new { });
        }


        public IEnumerable<RootsMagicPlace> GetPlaces()
        {
            return DbConnection.Query<RootsMagicPlace>("SELECT * FROM PlaceTable", param: new { });
        }

        public IEnumerable<RootsMagicRole> GetRoles()
        {
            return DbConnection.Query<RootsMagicRole>("SELECT * FROM RoleTable", param: new { });
        }

        public IEnumerable<RootsMagicSource> GetSources()
        {
            return DbConnection.Query<RootsMagicSource>("SELECT * FROM SourceTable", param: new { });
        }

        public IEnumerable<RootsMagicSourceTemplate> GetSourceTemplates()
        {
            return DbConnection.Query<RootsMagicSourceTemplate>("SELECT * FROM SourceTemplateTable", param: new { });
        }

        public IEnumerable<RootsMagicUrl> GetUrls()
        {
            return DbConnection.Query<RootsMagicUrl>("SELECT * FROM UrlTable", param: new { });
        }

        public IEnumerable<RootsMagicWitness> GetWitnesses()
        {
            return DbConnection.Query<RootsMagicWitness>("SELECT * FROM WitnessTable", param: new { });
        }
    }
}
