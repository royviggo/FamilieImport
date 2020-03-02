using FamilieImport.Gedcom.Enums;
using System.Collections.Generic;
using System.Text;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomRecord
    {
        public GedcomRecord()
        {
            GedcomLines = new List<GedcomLine>();
        }

        public GedcomRecordType RecordType { get; set; }
        public GedcomXref Id { get; set; }
        public string Value { get; set; }
        public GedcomXref Pointer { get; set; }

        public List<GedcomLine> GedcomLines { get; set; }

        public void Clear()
        {
            RecordType = GedcomRecordType.Unknown;
            Id = null;
            Value = "";
            Pointer = null;
            GedcomLines.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(RecordType.ToString());
            sb.Append(" ");
            sb.Append(Id);
            sb.Append(" ");
            sb.Append(Value);
            sb.AppendLine(Pointer.ToString());

            foreach (var line in GedcomLines)
            {
                sb.AppendLine(line.ToString());
            }

            return sb.ToString();
        }
    }
}