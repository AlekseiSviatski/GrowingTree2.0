using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingTree2._0
{
    class Tree
    {
        public string name { get; set; }
        public int age { get; set; }
        public int trunklength { get; set; }
        public int crownvolume { get; set; }

        public Tree(string name = default, int age = default, int trunklength = default, int crownvolume = default)
        {
            this.name = name;
            this.age = age;
            this.trunklength = trunklength;
            this.crownvolume = crownvolume;
        }

        public string TreeGetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Constants.TreeName);
            sb.Append(name);
            sb.Append(Constants.TreeAge);
            sb.Append(age);
            sb.Append(Constants.constage);
            sb.Append(Constants.TreeTrunkLength);
            sb.Append(trunklength);
            sb.Append(Constants.length);
            sb.Append(Constants.TreeCrownVolume);
            sb.Append(crownvolume);
            sb.Append(Constants.volume);
            return sb.ToString();
        }

        public void Grow()
        {
            age += 1;
            trunklength += 2;
            crownvolume += 5;
        }
    }
}
