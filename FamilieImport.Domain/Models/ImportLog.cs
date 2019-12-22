using System;

namespace FamilieImport.Domain.Models
{
    public class ImportLog
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public DateTime Imported { get; set; }
        public int Status { get; set; }
    }
}
