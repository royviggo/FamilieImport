using FamilieImport.Gedcom.Utils;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomId
    {
        public GedcomId(string id)
        {
            Id = GedcomUtil.CleanId(id);
        }

        public string Id { get; set; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Id) ? $"@{Id}@" : string.Empty;
        }
    }
}
