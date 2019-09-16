using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using static XMLApiProject.Utilities.Race;

namespace XMLApiProject.Models
{    
    public class PlayerCharacter
    {
        public int HitPoints { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public Races Race { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public List<string> Feats { get; set; }
        
    }
}
