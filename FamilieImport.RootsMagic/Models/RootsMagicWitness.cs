namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicWitness
    {
        public int WitnessID { get; set; }
        public int EventID { get; set; }
        public int PersonID { get; set; }
        public int WitnessOrder { get; set; }
        public int Role { get; set; }
        public string Sentence { get; set; }
        public string Note { get; set; }
        public string Given { get; set; }
        public string Surname { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
    }
}
