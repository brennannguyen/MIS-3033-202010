using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfAppClasses2
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle;

        /// <summary>
        /// Default/empty constructor.
        /// </summary>
        public Toy()
        {
            Manufacturer = "manufacturer";
            Name = "name";
            Price = 0.00;
            Aisle = "A1";
        }

        public string GetAisle()
        {
            string firstLetter;
            string aislenumber;
            firstLetter = Manufacturer.Substring(0, 1);
            aislenumber = Price.ToString();
            aislenumber = aislenumber.Replace(",", "");
            aislenumber = aislenumber.Replace(".", "");
            aislenumber = aislenumber.Replace("$", "");
            string aisle = $"{firstLetter.ToUpper()} - {aislenumber}";

            return aisle;
        }



    }
}
