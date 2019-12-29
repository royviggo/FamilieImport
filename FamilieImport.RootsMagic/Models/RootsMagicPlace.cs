using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicPlace : IImportEntity
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

        [JsonIgnore]
        public string ItemId => PlaceID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Place;
    }
}
