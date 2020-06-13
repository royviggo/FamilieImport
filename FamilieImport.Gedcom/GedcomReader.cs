using FamilieImport.Gedcom.Models;
using FamilieImport.Gedcom.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FamilieImport.Gedcom
{
    public class GedcomReader
    {
        private GedcomLine _nextLine;
        private TextReader _reader;

        public GedcomReader(StreamReader reader)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(StreamReader));
        }

        public GedcomReader(StringReader reader)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(StringReader));
        }

        public List<GedcomLineCollection> Read()
        {
            var document = new GedcomDocument();
            var records = new List<GedcomLineCollection>();
            GedcomLineCollection activeRecord = new GedcomLineCollection();
            GedcomLine line;

            while ((line = ReadLine()) != null)
            {
                if (line.Level == 0 && activeRecord.GedcomLines.Any())
                {
                    records.Add(new GedcomLineCollection(activeRecord));
                    activeRecord.Clear();
                }

                activeRecord.GedcomLines.Add(line);
            }

            return records;
        }

        public GedcomLine ReadLine()
        {
            return GetNextLine();
        }

        private GedcomLine GetNextLine()
        {
            var line = _reader.ReadLine();
            var currentLine = _nextLine;

            if (line != null)
            {
                _nextLine = new GedcomLine(line);

                if (currentLine == null)
                {
                    currentLine = _nextLine;
                    GetNextLine();
                }
            }
            else
                _nextLine = null;

            return currentLine;
        }
    }
}
