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
            Console.WriteLine($"Contact '{name}' has been added with phone number '{phoneNo}'.");

        }

        public void Remove(string name)
        {
            string? phoneNo = null;
            if (contactInfo.TryGetValue(name, out phoneNo))
            {
                contactInfo.Remove(name);
                Console.WriteLine($"Contact '{name}' has been deleted.");
            }
            else
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }
        public void search (string name) 
        {
            string? phoneNumber = null;
            if (contactInfo.TryGetValue(name,out phoneNumber))
            {
                Console.WriteLine($"Contact found: '{name}' with phone number '{phoneNumber}'.");
            }
            Console.WriteLine($"Contact '{name}' not found.");
        }
    }
}