using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities
{
    public class Catagory
    {
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public SubCatagory SubCatagory { get; set; }
    }

   
}
