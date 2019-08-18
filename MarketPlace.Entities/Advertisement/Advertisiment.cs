using MarketPlace.Entities.Advertisement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MarketPlace.Entities.Common
{
    public class Advertisiment
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public List<Image> Image { get; set; }
        public Catagory Catagory { get; set; }
        public Bagde Bagde { get; set; }

        public Seller Seller { get; set; }
        public AdvertisementDetails Details { get; set; }

    }
}
