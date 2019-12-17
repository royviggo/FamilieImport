namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicPerson
    {
        public int PersonID { get; set; }
        public string UniqueID { get; set; }
        public int Sex { get; set; }
        public decimal EditDate { get; set; }
        public int ParentID { get; set; }
        public int SpouseID { get; set; }
        public int Color { get; set; }
        public int Relate1 { get; set; }
        public int Relate2 { get; set; }
        public int Flags { get; set; }
        public int Living { get; set; }
        public int IsPrivate { get; set; }
        public int Proof { get; set; }
        public int Bookmark { get; set; }
        public string Note { get; set; }
    }
}
