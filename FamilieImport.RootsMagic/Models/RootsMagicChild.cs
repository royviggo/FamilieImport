using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicChild : IImportEntity
    {
        public int RecID { get; set; }
        public int? ChildID { get; set; }
        public int? FamilyID { get; set; }
        public int? RelFather { get; set; }
        public int? RelMother { get; set; }
        public int? ChildOrder { get; set; }
        public int? IsPrivate { get; set; }
        public int? ProofFather { get; set; }
        public int? ProofMother { get; set; }
        public string Note { get; set; }

        [JsonIgnore]
        public string ItemId => RecID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Child;
    }
}
