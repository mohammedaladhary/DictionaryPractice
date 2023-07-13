using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    internal class Person
    {
        public long id {  get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        public Person(long id, string name, string gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
        }

        public override string ToString()
        {
            return ($"name: {name} gender: {gender}");
        }
    }
}
