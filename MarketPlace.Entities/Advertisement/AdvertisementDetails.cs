using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities.Advertisement
{
    public class AdvertisementDetails
    {
        public int Discount { get; set; }
        public string Description { get; set; }
        public DateTime CreationOn { get; set; }
        public DateTime ExpireOn { get; set; }

        public TimeSpan Duration { get; set; }
        public int Rank { get; set; }


    }
}
