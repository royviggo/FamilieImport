using FamilieImport.Gedcom.Enums;
using FamilieImport.Gedcom.Models;
using FamilieImport.Gedcom.Structures;
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace FamilieImport.Gedcom.Utils
{
    public static class GedcomUtil
    {
        private static readonly Regex _pointerRegex = new Regex(@"(?<id>@\w[\S]+@)");
        private static readonly Regex _gedcomRegex = new Regex(@"^\s*?(?<level>\d+)\s+(" + _pointerRegex + @"\s)?(?<tag>[\S]+)(\s+(?<value>.+))?");

        public static string CleanId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return string.Empty;

            try
            {
                return Regex.Replace(id, "@", "");
            }
            catch {}

            return string.Empty;
        }

        public static GedcomTag GetTag(string tag)
        {
            if (Enum.IsDefined(typeof(GedcomTag), tag))
                return (GedcomTag)Enum.Parse(typeof(GedcomTag), tag, true);

            return GedcomTag.UNKNOWN;
        }

        public static GedcomLine ParseLine(string line)
        {
            try
            {
                // Match the parts of the line
                var match = _gedcomRegex.Match(line);
                if (match.Success)
                {
                    var level = Convert.ToInt32(match.Groups["level"].Value, CultureInfo.InvariantCulture);
                    var id = match.Groups["id"].Value.Trim();
                    var tag = match.Groups["tag"].Value.Trim();
                    var value = match.Groups["value"].Value.Trim();
                    var pointer = "";

                    // See if we have a pointer in the value
                    var pointerMatch = _pointerRegex.Match(value);
                    if (pointerMatch.Success)
                    {
                        pointer = pointerMatch.Groups["id"].Value;
                        value = "";
                    }

                    return new GedcomLine(level, id, tag, value, pointer);
                }

                // If we got an error, we return an error line
                return ErrorLine(line);
            }
            catch
            {
                return ErrorLine(line);
            }
        }

        public static GedcomRecordType GetRecordTypeFromTag(GedcomTag tag)
        {
            switch (tag)
            {
                case GedcomTag.HEAD:
                    return GedcomRecordType.Header;
                case GedcomTag.SUBN:
                    return GedcomRecordType.Submission;
                case GedcomTag.FAM:
                    return GedcomRecordType.Family;
                case GedcomTag.INDI:
                    return GedcomRecordType.Individual;
                case GedcomTag.MEDI:
                    return GedcomRecordType.Multimedia;
                case GedcomTag.NOTE:
                    return GedcomRecordType.Note;
                case GedcomTag.REPO:
                    return GedcomRecordType.Repository;
                case GedcomTag.SOUR:
                    return GedcomRecordType.Source;
                case GedcomTag.SUBM:
                    return GedcomRecordType.Submitter;
                case GedcomTag.TRLR:
                    return GedcomRecordType.Trailer;
                default:
                    return GedcomRecordType.Unknown;
            }
        }

        public static GedcomLine ErrorLine(string line)
        {
            return new GedcomLine(99, "", "UNKNOWN", line, "");
        }

        public static IGedcomRecord GedcomRecordFactory(GedcomLineCollection record)
        {
            var firstLine = record.GedcomLines.FirstOrDefault();
            if (firstLine == null)
                return null;

            switch (GetRecordTypeFromTag(firstLine.Tag))
            {
                case GedcomRecordType.Header:
                    return new HeaderRecord(record);
                case GedcomRecordType.Submission:
                    return null;
                case GedcomRecordType.Family:
                    return null;
                case GedcomRecordType.Individual:
                    return null;
                case GedcomRecordType.Multimedia:
                    return null;
                case GedcomRecordType.Note:
                    return null;
                case GedcomRecordType.Repository:
                    return null;
                case GedcomRecordType.Source:
                    return null;
                case GedcomRecordType.Submitter:
                    return null;
                case GedcomRecordType.Trailer:
                    return null;
                case GedcomRecordType.Unknown:
                    return null;
                default:
                    return null;
            }
        }
    }
}
