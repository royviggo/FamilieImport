using FamilieImport.Gedcom.Utils;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomXref
    {
        public GedcomXref(string id)
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
