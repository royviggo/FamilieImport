namespace FamilieImport.Domain.Models
{
    public class ImportSourceType
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public int SourceType { get; set; }
        public bool HasUserName { get; set; }
        public bool HasPassword { get; set; }
        public bool HasApiKey { get; set; }
    }
}
