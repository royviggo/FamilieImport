using FamilieImport.Gedcom.Models;
using FamilieImport.Gedcom.Utils;
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

        public List<GedcomRecord> Read()
        {
            var records = new List<GedcomRecord>();
            var activeRecord = new GedcomRecord();
            GedcomLine line;

            while ((line = ReadLine()) != null)
            {
                if (line.Level == 0)
                {
                    var record = new GedcomRecord
                    {
                        RecordType = GedcomUtil.GetRecordTypeFromTag(line.Tag),
                        Id = line.Id,
                        Value = line.Value,
                        Pointer = line.Pointer
                    };
                    records.Add(record);
                    activeRecord = record;
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
