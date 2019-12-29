using FamilieImport.Domain;
using FamilieImport.Domain.Extensions;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicSource : IImportEntity
    {
        public int SourceID { get; set; }
        public string Name { get; set; }
        public string RefNumber { get; set; }
        public string ActualText { get; set; }
        public string Comments { get; set; }
        public int IsPrivate { get; set; }
        public int TemplateID { get; set; }

        [JsonIgnore]
        public byte[] Fields { get; set; }

        public string FieldsString => Fields.ToNormalString();

        [JsonIgnore]
        public string ItemId => SourceID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Source;
    }
}
