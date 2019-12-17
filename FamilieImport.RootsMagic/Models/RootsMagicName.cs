namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicName
    {
        public int NameID { get; set; }
        public int OwnerID { get; set; }
        public string Surname { get; set; }
        public string Given { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Nickname { get; set; }
        public int NameType { get; set; }
        public string Date { get; set; }
        public int SortDate { get; set; }
        public int IsPrimary { get; set; }
        public int IsPrivate { get; set; }
        public int Proof { get; set; }
        public decimal EditDate { get; set; }
        public string Sentence { get; set; }
        public string Note { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
    }
}
