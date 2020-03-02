using FamilieImport.Gedcom.Structures;
using System.Collections.Generic;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomDocument
    {
        public GedcomDocument()
        {
        }

        public Dictionary<GedcomXref, GedcomRecord> CrossReferences { get; set; }
        public List<GedcomRecord> GedcomRecords { get; set; }

        public HeaderRecord HeaderRecord { get; set; }
        public SubmissionRecord SubmissionRecord { get; set; }
        public List<FamilyRecord> FamilyRecords { get; set; }
        public List<IndividualRecord> IndividualRecords { get; set; }
        public List<MultimediaRecord> MultimediaRecords { get; set; }
        public List<NoteRecord> NoteRecords { get; set; }
        public List<RepositoryRecord> RepositoryRecords { get; set; }
        public List<SourceRecord> SourceRecords { get; set; }
        public List<SubmitterRecord> SubmitterRecords { get; set; }
    }
}
