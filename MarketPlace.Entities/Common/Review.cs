using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities.Common
{
    public class Review
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Stars { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsVisible { get; set; }


    }
}
