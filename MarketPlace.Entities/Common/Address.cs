using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities
{
    public class Address
    {
        public String StreetAddress { get; set; }
        public string HouseNumber { get; set; }

        public City City { get; set; }

        public Country Country { get; set; }
        

    }
}
