using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    internal class Contacts
    {
        private Dictionary<string,string> contactInfo;

        public Contacts() 
        {
            contactInfo = new Dictionary<string,string>();
        }

        public void Add(string name, string phoneNo) 
        {
            contactInfo[name] = phoneNo;
        }

        public string? Remove(string name) 
        {
            string? phoneNo = null;
            if(contactInfo.TryGetValue(name, out phoneNo)) 
            {
                return phoneNo;
            }
            return null;
        }
    }
}
