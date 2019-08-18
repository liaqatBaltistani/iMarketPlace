using MarketPlace.Entities.Common;
using MarketPlace.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities.Oders
{


    public class Order
    {
        public string OrderCode { get; set; }
        public Advertisiment Advertisiment { get; set; }
        public Buyer Buyer { get; set; }

        public int MyProperty { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
