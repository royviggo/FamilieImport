namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicEvent
    {
        public int EventID { get; set; }
        public int EventType { get; set; }
        public int OwnerType { get; set; }
        public int OwnerID { get; set; }
        public int FamilyID { get; set; }
        public int PlaceID { get; set; }
        public int SiteID { get; set; }
        public string Date { get; set; }
        public int SortDate { get; set; }
        public int IsPrimary { get; set; }
        public int IsPrivate { get; set; }
        public int Proof { get; set; }
        public int Status { get; set; }
        public decimal EditDate { get; set; }
        public string Sentence { get; set; }
        public string Details { get; set; }
        public string Note { get; set; }
    }
}
