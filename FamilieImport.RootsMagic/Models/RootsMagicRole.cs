using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicRole : IImportEntity
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int EventType { get; set; }
        public int RoleType { get; set; }
        public string Sentence { get; set; }

        [JsonIgnore]
        public string ItemId => RoleID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Role;
    }
}
