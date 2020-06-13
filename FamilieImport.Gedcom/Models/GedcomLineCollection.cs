using FamilieImport.Gedcom.Enums;
using System.Collections.Generic;
using System.Text;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomLineCollection : GedcomLine
    {
        public GedcomLineCollection()
        {
            GedcomLines = new List<GedcomLine>();
        }

        public GedcomLineCollection(string line)
        {
            GedcomLines = new List<GedcomLine>();
            GedcomLines.Add(new GedcomLine(line));
        }

        public GedcomLineCollection(GedcomLine gedcomLine)
        {
            GedcomLines = new List<GedcomLine>();
            GedcomLines.Add(gedcomLine);
        }

        public GedcomLineCollection(GedcomLineCollection gedcomLineCollection)
        {
            GedcomLines = new List<GedcomLine>();
            GedcomLines.AddRange(gedcomLineCollection.GedcomLines);
        }

        public GedcomLineCollection(int level, string id, string tag, string value, string pointer) : base(level, id, tag, value, pointer)
        {
            GedcomLines = new List<GedcomLine>();
        }

        public List<GedcomLine> GedcomLines { get; set; }


        public void Clear()
        {
            Level = 0;
            Id = null;
            Tag = GedcomTag.UNKNOWN;
            Value = "";
            Pointer = null;
            GedcomLines.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());

            foreach (var line in GedcomLines)
            {
                sb.AppendLine(line.ToString());
            }

            return sb.ToString();
        }
    }
}