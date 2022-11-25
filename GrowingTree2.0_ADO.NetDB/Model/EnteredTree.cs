using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GrowingTree2._0_ADO.NetDB.Model
{
    public class EnteredTree
    {
        public EnteredTree()
        {
        }

        public EnteredTree(string name, int age, int trunkLength, int crownVolume)
        {

        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TrunkLength { get; set; }
        public int CrownVolume { get; set; }
    }
}
