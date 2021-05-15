using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Inventory
{

    class Shipper
    {
        private IShippable[] shoppingCart = new IShippable[10];

        private IShippable currentItem;

        private int shoppingCartIndex;
        private int numBaseballGloves;
        private int numBicycles;
        private int numCrackers;
        private int numLawnMowers;

        private decimal totalShippingCost;

        public string GetShipperMenu()
        {
            return "Choose from the following options:"
                + "\n1. Add a Bicycle to the shipment"
                + "\n2. Add a Lawn Mower to the shipment"
                + "\n3. Add a Baseball Glove to the shipment"
                + "\n4. Add Crackers to the shipment"
                + "\n5. List Shipment Items"
                + "\n6. Compute Shipping Charges"; ;
        }

        public string GetConfirmation()
        {
            return "1 " + currentItem.Product + " has been added"
                + "\n Press any key to return to the menu"; ;
        }

        public void Add(IShippable item)
        {
            shoppingCart[shoppingCartIndex] = item;
            currentItem = item;
            shoppingCartIndex++;
            totalShippingCost += item.ShipCost;

            UpdateItemIndex(item);
        }

        public string GetShippingCharges()
        {
            if(totalShippingCost >= 1.00M)
                return string.Format("Total shipping costs for this order is: {0:C}", totalShippingCost);
            else
                return string.Format("Total shipping costs for this order is: ${0:.00}", totalShippingCost);
        }

        public string ListItems()
        {
            string s = "Shipping manifest:";

            if(numBicycles > 1)
                s += "\n" + numBicycles + " Bicycles";
            else
                s += "\n" + numBicycles + " Bicycle";

            if(numBaseballGloves > 1)
                s += "\n" + numBaseballGloves + " Baseball Gloves";
            else
                s += "\n" + numBaseballGloves + " Baseball Glove";

            if (numLawnMowers > 1)
                s += "\n" + numLawnMowers + " Lawn Mowers";
            else
                s += "\n" + numLawnMowers + " Lawn Mower";

            s += "\n" + numCrackers + " Crackers";

            return s;
        }

        private void UpdateItemIndex(IShippable item)
        {
            if (item.Product == "Baseball Glove")
                numBaseballGloves++;
            else if (item.Product == "Bicycle")
                numBicycles++;
            else if (item.Product == "Lawn Mower")
                numLawnMowers++;
            else if (item.Product == "Crackers")
                numCrackers++;
        }
    }
}
