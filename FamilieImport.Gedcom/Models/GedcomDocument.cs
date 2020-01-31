using System;
using System.Collections.Generic;
using System.Text;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomDocument
    {
        //private readonly Dictionary<GedcomId, GedcomRecord> _xReferences = new Dictionary<GedcomId, GedcomRecord>();
        //private readonly List<GedcomRecord> _gedcomRecords = new List<GedcomRecord>();

        public GedcomDocument()
        {
        }

        public Dictionary<GedcomId, GedcomRecord> CrossReferences { get; set; }
        public List<GedcomRecord> GedcomRecords { get; set; }
    }
}
