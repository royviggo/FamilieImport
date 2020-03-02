using System.Collections.Generic;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomDocument
    {
        //private readonly Dictionary<GedcomId, GedcomRecord> _xReferences = new Dictionary<GedcomId, GedcomRecord>();
        //private readonly List<GedcomRecord> _gedcomRecords = new List<GedcomRecord>();

        public GedcomDocument()
        {
        }

        public Dictionary<GedcomXref, GedcomRecord> CrossReferences { get; set; }
        public List<GedcomRecord> GedcomRecords { get; set; }
    }
}
