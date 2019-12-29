using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicMultimedia : IImportEntity
    {
        public int MediaID { get; set; }
        public int MediaType { get; set; }
        public string MediaPath { get; set; }
        public string MediaFile { get; set; }
        public string URL { get; set; }
        public byte[] Thumbnail { get; set; }
        public string Caption { get; set; }
        public string RefNumber { get; set; }
        public string Date { get; set; }
        public int SortDate { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public string ItemId => MediaID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Multimedia;
    }
}
