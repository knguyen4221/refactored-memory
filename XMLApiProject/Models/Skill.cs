using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLApiProject.Models
{
    public class Skill
    {
        [XmlAttribute]
        public string SkillName { get; set; }
        [XmlAttribute]
        public int Rank { get; set; }
    }
}
