using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wagoner_Inventory
{

    class Shipper
    {
        private readonly IShippable[] shoppingCart = new IShippable[10];

        private IShippable currentItem;

        private int shoppingCartIndex;
        private int numBaseballGloves;
        private int numBicycles;
        private int numCrackers;
        private int numLawnMowers;

        public string GetConfirmation()
        {
            return "1 " + currentItem.Product + " has been added"
                + "\n Press any key to return to the menu";
        }

        public void Add(IShippable item)
        {
            shoppingCart[shoppingCartIndex] = item;
            currentItem = item;
            shoppingCartIndex++;

            UpdateItemIndex(item);
        }

        public string GetShippingCharges()
        {
            return string.Format(
                "Total shipping cost for this order is: ${0:.00}" 
                + "\nPress any key to terminate", 
                ComputeShippingCharges());
        }
        
        private decimal ComputeShippingCharges()
        {
            decimal totalShippingCost = 0;

            for(int i = 0; i < shoppingCart.Length; i++)
            {
                if(shoppingCart[i] != null)
                totalShippingCost += shoppingCart[i].ShipCost;
            }    

            return totalShippingCost;
        }

        public string ListItems()
        {
            string s = "Shipping manifest:";

            if(numBicycles > 1)
                s += "\n" + numBicycles + " Bicycles";
            else if(numBicycles == 1)
                s += "\n" + numBicycles + " Bicycle";

            if(numBaseballGloves > 1)
                s += "\n" + numBaseballGloves + " Baseball Gloves";
            else if(numBaseballGloves == 1)
                s += "\n" + numBaseballGloves + " Baseball Glove";

            if (numLawnMowers > 1)
                s += "\n" + numLawnMowers + " Lawn Mowers";
            else if(numLawnMowers == 1)
                s += "\n" + numLawnMowers + " Lawn Mower";

            if(numCrackers > 0)
            s += "\n" + numCrackers + " Crackers";

            s += "\nPress any key to return to the menu";
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
