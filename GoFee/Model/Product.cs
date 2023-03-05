using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFee.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int StoreID { get; set; }
        public int ProductID { get; set; }
        public int Stock { get; set; }
    }
}
