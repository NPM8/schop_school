using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSchoolv4.Models
{
    public class Product
    {
        public int ID { get; set; }

        public double Cost { get; set; }

        public string ProductName { get; set; }

        public string ImgUrl { get; set; }

        public string Description { get; set; }

        public int Category { get; set; }
    }
}