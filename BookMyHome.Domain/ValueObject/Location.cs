using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyHome.Domain.ValueObject
{
    public record Location 
    {
        public string StreetName { get; private set; }
        public int Zipcode { get; private set; }
        public string City { get; private set; }

        public Location(string streetName, int zipcode, string city)
        {
            StreetName = streetName;
            City = city;
            Zipcode = zipcode;
        }
    }
}
