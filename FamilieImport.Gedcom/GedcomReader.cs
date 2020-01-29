using FamilieImport.Gedcom.Models;
using System;
using System.Collections.Generic;
using System.IO;

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

        public List<GedcomLine> Read()
        {
            var lines = new List<GedcomLine>();
            GedcomLine line;

            while ((line = ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines;
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
