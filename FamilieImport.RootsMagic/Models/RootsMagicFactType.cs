using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicFactType : IImportEntity
    {
        public int FactTypeID { get; set; }
        public int OwnerType { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public string GedcomTag { get; set; }
        public int UseValue { get; set; }
        public int UseDate { get; set; }
        public int UsePlace { get; set; }
        public string Sentence { get; set; }
        public int Flags { get; set; }

        [JsonIgnore]
        public string ItemId => FactTypeID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.FactType;
    }
}
