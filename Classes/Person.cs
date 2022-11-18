using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingTree2._0
{
    class Person
    {
        public Person(string personname = "Безымянный", int watering = default)
        {
            this.personname = personname;
            this.watering = watering;
        }

        string personname { get; set; }
        public int watering { get; set; }

        public string PersonGetInfo()
        {
            return $"ФИО: {personname} \nКол-во поливов: {watering}";
        }

        public void AddWateringCount()
        {
            watering += 1;
        }
    }
}
