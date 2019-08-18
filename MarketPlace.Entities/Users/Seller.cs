using MarketPlace.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities
{
    public class Seller :User
    {
        public List<Advertisiment> Advertisements { get; set; }

        public List<Review> Reviews { get; set; }


    }

}

