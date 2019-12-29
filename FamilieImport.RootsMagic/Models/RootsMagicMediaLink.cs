using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicMediaLink : IImportEntity
    {
        public int LinkID { get; set; }
        public int MediaID { get; set; }
        public int OwnerType { get; set; }
        public int OwnerID { get; set; }
        public int IsPrimary { get; set; }
        public int Include1 { get; set; }
        public int Include2 { get; set; }
        public int Include3 { get; set; }
        public int Include4 { get; set; }
        public int SortOrder { get; set; }
        public int RectLeft { get; set; }
        public int RectTop { get; set; }
        public int RectRight { get; set; }
        public int RectBottom { get; set; }
        public string Note { get; set; }
        public string Caption { get; set; }
        public string RefNumber { get; set; }
        public string Date { get; set; }
        public long SortDate { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public string ItemId => LinkID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.MediaLink;
    }
}
