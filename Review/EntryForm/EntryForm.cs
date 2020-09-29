using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryForm
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        /// <summary>
        /// Default/Empty Constructor.
        /// </summary>
        public EntryForm()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }

        /// <summary>
        /// Converts string to desired string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string sentence = $"Name: {Name}, Address: {Address}, Zip Code: {ZipCode}";
            return sentence;
        }
    }
}
