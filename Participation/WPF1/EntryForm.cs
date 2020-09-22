using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        /// <summary>
        /// Empty/Default Constructor
        /// </summary>
        public EntryForm ()
        {
            Name = "";
            Address = "";
            ZipCode = 00000;
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        public EntryForm(string name, string address, int zipCode)
        {
            this.Name = name;
            this.Address = address;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// Convert String to desired string format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = $"{Name} , {Address}, {ZipCode}";
            return result; 
        }
    }
}
