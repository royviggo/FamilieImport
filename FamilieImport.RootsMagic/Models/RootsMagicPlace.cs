namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicPlace
    {
        public int PlaceID { get; set; }
        public int PlaceType { get; set; }
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public string Normalized { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int LatLongExact { get; set; }
        public int MasterID { get; set; }
        public string Note { get; set; }
    }
}
