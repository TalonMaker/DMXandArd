using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestDmx2.Models
{
    class DMXFixtures
    {
        public DMXFixtures() {
            DMXfixtureList = new List<DMXfixture>();
            //32 fixtures
            for (int i = 0; i < 32; i++) { 
            DMXfixtureList.Add(new DMXfixture());
            }

        }
        public DMXFixtures ShallowCopy()
        {
            return (DMXFixtures)this.MemberwiseClone();
        }
        public List<DMXfixture> DMXfixtureList {  get; set; }
        public DMXFixtures DeepCopy()
        {
            DMXFixtures other = (DMXFixtures)this.MemberwiseClone();
            other.DMXfixtureList = other.DMXfixtureList.GetRange(0, other.DMXfixtureList.Count);
            return other;
        }
    }
    class DMXfixture
    {
        public DMXfixture() {
            Channels = new List<int>();
            //Channels each fixture
            for (int i = 0; i < 16; i++)
            {
                Channels.Add(0);
            }
            fixture_enabled = false;
            isIndividual = false;
        }
        public DMXfixture ShallowCopy()
        {
            return (DMXfixture)this.MemberwiseClone();
        }
        public List<int> Channels { get; set; }
        public Boolean fixture_enabled { get; set; }
        public Boolean isIndividual { get; set; }
    }
    class DMXARDproject
    {
       public DMXARDproject()
        {
            Scenes = new Dictionary<string, DMXFixtures>();
            Scenes.Add("(AutoSaveScene)",new DMXFixtures());
        }
        public DMXARDproject ShallowCopy()
        {
            return (DMXARDproject)this.MemberwiseClone();
        }
        public Dictionary<String,DMXFixtures> Scenes { get; set; }
}
}
