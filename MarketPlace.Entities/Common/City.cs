using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities
{
    public class City
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public List<Address> Addresses { get; set; }


    }
}
