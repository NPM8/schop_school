using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSchoolv4.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string Login { get; set; }

        public int Bascket { get; set; }

        public string isAdmin { get; set; }

    }
}