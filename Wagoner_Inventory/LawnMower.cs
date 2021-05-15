using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Inventory
{
    class LawnMower : IShippable
    {
        private const decimal SHIPPING_COST = 24.00M;
        private const string PRODUCT_NAME = "Lawn Mower";
        public decimal ShipCost { get { return SHIPPING_COST; } }

        public string Product { get { return PRODUCT_NAME; } }
    }
}
