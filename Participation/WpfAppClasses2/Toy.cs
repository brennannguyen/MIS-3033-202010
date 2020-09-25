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
            Manufacturer = "";
            Name = "";
            Price = 0.00;
            Aisle = "";
        }

        /// <summary>
        /// Method to return Aisle number.
        /// </summary>
        /// <returns></returns>
        public string GetAisle()
        {
            string firstLetter;
            string aislenumber;
            firstLetter = Manufacturer.Substring(0, 1);
            aislenumber = Price.ToString();
            aislenumber = aislenumber.Replace(",", "");
            aislenumber = aislenumber.Replace(".", "");
            aislenumber = aislenumber.Replace("$", "");
            Aisle = $"{firstLetter.ToUpper()}{aislenumber}";
            return Aisle;
        }

        public override string ToString()
        {
            string result = $"{Manufacturer} - {Name}";
            return result;
        }

    }
}
