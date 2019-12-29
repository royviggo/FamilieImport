using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicUrl : IImportEntity
    {
        public int LinkID { get; set; }
        public int OwnerType { get; set; }
        public int OwnerID { get; set; }
        public int LinkType { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }

        [JsonIgnore]
        public string ItemId => LinkID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Url;
    }
}
