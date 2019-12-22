namespace FamilieImport.Domain.Models
{
    public class ImportData
    {
        public int Id { get; set; }
        public int LogId { get; set; }
        public int ItemTypeId { get; set; }
        public string ItemId { get; set; }
        public string CheckSum { get; set; }
        public string Data { get; set; }
    }
}
