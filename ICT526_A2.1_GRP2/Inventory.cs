using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT526_A2._1_GRP2
{
    class Inventory
    {
        public string Name { get; set; }
        public string ItemCode { get; set; }
        public string Quantity { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }

        public override string ToString()
        {
            return ItemCode;
        }
    }
}
