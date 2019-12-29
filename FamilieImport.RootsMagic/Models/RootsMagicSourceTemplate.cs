using FamilieImport.Domain;
using FamilieImport.Domain.Extensions;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicSourceTemplate : IImportEntity
    {
        public int TemplateID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Favorite { get; set; }
        public string Category { get; set; }
        public string Footnote { get; set; }
        public string ShortFootnote { get; set; }
        public string Bibliography { get; set; }

        [JsonIgnore]
        public byte[] FieldDefs { get; set; }

        public string FieldsString => FieldDefs.ToNormalString();

        [JsonIgnore]
        public string ItemId => TemplateID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.SourceTemplate;
    }
}
