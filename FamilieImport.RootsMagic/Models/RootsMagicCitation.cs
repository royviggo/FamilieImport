namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicCitation
    {
        public int CitationID { get; set; }
        public int OwnerType { get; set; }
        public int SourceID { get; set; }
        public int OwnerID { get; set; }
        public string Quality { get; set; }
        public int IsPrivate { get; set; }
        public string Comments { get; set; }
        public string ActualText { get; set; }
        public string RefNumber { get; set; }
        public int Flags { get; set; }
        public string Fields { get; set; }
    }
}
