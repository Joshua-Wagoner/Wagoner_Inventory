using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Inventory
{
    class BaseballGlove : IShippable
    {
        private const decimal SHIPPING_COST = 3.23M;
        private const string PRODUCT_NAME = "Baseball Glove";

        public decimal ShipCost { get { return SHIPPING_COST; } }

        public string Product { get { return PRODUCT_NAME; } }
    }
}
