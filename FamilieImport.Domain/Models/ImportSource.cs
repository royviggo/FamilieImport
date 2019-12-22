using System;

namespace FamilieImport.Domain.Models
{
    public class ImportSource
    {
        public int Id { get; set; }
        public int SourceTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string UserKey { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
