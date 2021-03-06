﻿using FamilieImport.Domain;
using FamilieImport.RootsMagic.Enums;
using System.Text.Json.Serialization;

namespace FamilieImport.RootsMagic.Models
{
    public class RootsMagicFamily : IImportEntity
    {
        public int FamilyID { get; set; }
        public int FatherID { get; set; }
        public int MotherID { get; set; }
        public int ChildID { get; set; }
        public int HusbOrder { get; set; }
        public int WifeOrder { get; set; }
        public int IsPrivate { get; set; }
        public int Proof { get; set; }
        public int SpouseLabel { get; set; }
        public int FatherLabel { get; set; }
        public int MotherLabel { get; set; }
        public string Note { get; set; }

        [JsonIgnore]
        public string ItemId => FamilyID.ToString();
        [JsonIgnore]
        public int ItemType => (int)RootsMagicItemType.Family;
    }
}
