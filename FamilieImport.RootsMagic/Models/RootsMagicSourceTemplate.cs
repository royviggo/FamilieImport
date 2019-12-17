namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicSourceTemplate
    {
        public int TemplateID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Favorite { get; set; }
        public string Category { get; set; }
        public string Footnote { get; set; }
        public string ShortFootnote { get; set; }
        public string Bibliography { get; set; }
        public string FieldDefs { get; set; }
    }
}
