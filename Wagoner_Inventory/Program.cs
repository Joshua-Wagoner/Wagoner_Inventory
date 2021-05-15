using System;

namespace Wagoner_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();

            Console.WriteLine(shipper.GetShipperMenu());

            shipper.Add(new Crackers());
            Console.WriteLine(shipper.GetConfirmation());

            Console.WriteLine(shipper.ListItems());
            Console.WriteLine(shipper.GetShippingCharges());

            Console.Read();
        }
    }
}
