using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Inventory
{
    class Crackers : IShippable
    {
        private const decimal SHIPPING_COST = .57M;
        private const string PRODUCT_NAME = "Crackers";

        public decimal ShipCost { get { return SHIPPING_COST; } }

        public string Product { get { return PRODUCT_NAME; } }
    }
}
