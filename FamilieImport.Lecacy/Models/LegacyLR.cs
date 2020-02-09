namespace FamilieImport.Legacy.Models
{
    public class LegacyLR
    {
        public int IDLR { get; set; }
        public string Preposition { get; set; }
        public string Location { get; set; }
        public string SortedLocation { get; set; }
        public string ShortName { get; set; }
        public int Tag1 { get; set; }
        public int Used { get; set; }
        public string Notes { get; set; }
        public int Verified { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int FSResolved { get; set; }
        public int VEResolved { get; set; }
        public string FSPlaceID { get; set; }
        public int FSPlaceFlag { get; set; }
    }
}
