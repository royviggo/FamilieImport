using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicEvent : IImportEntity
    {
        public int EventID { get; set; }
        public int? EventType { get; set; }
        public int? OwnerType { get; set; }
        public int? OwnerID { get; set; }
        public int? FamilyID { get; set; }
        public int? PlaceID { get; set; }
        public int? SiteID { get; set; }
        public string Date { get; set; }
        public long? SortDate { get; set; }
        public int? IsPrimary { get; set; }
        public int? IsPrivate { get; set; }
        public int? Proof { get; set; }
        public int? Status { get; set; }
        public decimal? EditDate { get; set; }
        public string Sentence { get; set; }
        public string Details { get; set; }
        public string Note { get; set; }

        [JsonIgnore]
        public string ItemId => EventID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Event;
    }
}
