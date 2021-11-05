using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2010A_UWP.Models.Entity
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Categories
    {
        public string message { get; set; }
        public List<Category> data { get; set; }
    }


}
