namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicSource
    {
        public int SourceID { get; set; }
        public string Name { get; set; }
        public string RefNumber { get; set; }
        public string ActualText { get; set; }
        public string Comments { get; set; }
        public int IsPrivate { get; set; }
        public int TemplateID { get; set; }
        public string Fields { get; set; }
    }
}
