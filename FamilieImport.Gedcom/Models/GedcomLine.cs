using FamilieImport.Gedcom.Enums;
using FamilieImport.Gedcom.Utils;

namespace FamilieImport.Gedcom.Models
{
    public class GedcomLine
    {
        public GedcomLine(string line)
        {
            var gedcomLine = GedcomUtil.ParseLine(line);
            Level = gedcomLine.Level;
            Id = gedcomLine.Id;
            Tag = gedcomLine.Tag;
            Value = gedcomLine.Value;
            Pointer = gedcomLine.Pointer;
        }

        public GedcomLine(GedcomLine gedcomLine)
        {
            Level = gedcomLine.Level;
            Id = gedcomLine.Id;
            Tag = gedcomLine.Tag;
            Value = gedcomLine.Value;
            Pointer = gedcomLine.Pointer;
        }

        public GedcomLine(int level, string id, string tag, string value, string pointer)
        {
            Level = level;
            Id = new GedcomXref(id);
            Tag = GedcomUtil.GetTag(tag);
            Value = value;
            Pointer = new GedcomXref(pointer);
        }

        public int Level { get; set; }
        public GedcomXref Id { get; set; }
        public GedcomTag Tag { get; set; }
        public string Value { get; set; }
        public GedcomXref Pointer { get; set; }

        public override string ToString()
        {
            return $"{Level} " + (Id.ToString() != "" ? Id + " " : "") + Tag.ToString() + 
                (Value != "" || Pointer.ToString() != "" ? $" {Value}{Pointer}" : "");
        }
    }
}
