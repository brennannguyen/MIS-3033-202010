using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClasses3
{
    class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        public Address()
        {
            StreetNumber = 0;
            StreetName = "";
            State = "";
            City = "";
            Zipcode = 0;
        }

        public Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            this.StreetNumber = streetnumber;
            this.StreetName = streetname;
            this.State = state;
            this.City = city;
            this.Zipcode = zipcode;
        }
    }
}
