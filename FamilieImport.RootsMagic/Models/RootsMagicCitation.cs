using FamilieImport.Domain;
using FamilieImport.Domain.Extensions;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicCitation : IImportEntity
    {
        public int CitationID { get; set; }
        public int? OwnerType { get; set; }
        public int? SourceID { get; set; }
        public int? OwnerID { get; set; }
        public string Quality { get; set; }
        public int? IsPrivate { get; set; }
        public string Comments { get; set; }
        public string ActualText { get; set; }
        public string RefNumber { get; set; }
        public int? Flags { get; set; }
        
        [JsonIgnore]
        public byte[] Fields { get; set; }

        public string FieldsString => Fields.ToNormalString();

        [JsonIgnore]
        public string ItemId => CitationID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Citation;
    }
}
