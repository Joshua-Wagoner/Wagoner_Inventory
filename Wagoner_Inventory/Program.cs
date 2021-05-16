using System;
/* Joshua Wagoner
 * IT112
 * Notes: This was quite challenging, but I learned a lot from it!
 * The code is portable,
 * Behaviors not implemented, and why: All behaviors implemented.
 */
namespace Wagoner_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            ConsoleKeyInfo key;

            bool optOut = false;

            while(!optOut)
            {
                Console.WriteLine(
                    "Choose from the following options:"
                    + "\n1. Add a Bicycle to the shipment"
                    + "\n2. Add a Lawn Mower to the shipment"
                    + "\n3. Add a Baseball Glove to the shipment"
                    + "\n4. Add Crackers to the shipment"
                    + "\n5. List Shipment Items"
                    + "\n6. Compute Shipping Charges");

                key = Console.ReadKey(true);

                Console.WriteLine();

                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    shipper.Add(new Bicycle());
                    Console.Clear();
                    Console.WriteLine(shipper.GetConfirmation());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    shipper.Add(new LawnMower());
                    Console.Clear();
                    Console.WriteLine(shipper.GetConfirmation());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    shipper.Add(new BaseballGlove());
                    Console.Clear();
                    Console.WriteLine(shipper.GetConfirmation());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                {
                    shipper.Add(new Crackers());
                    Console.Clear();
                    Console.WriteLine(shipper.GetConfirmation());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
                {
                    Console.Clear();
                    Console.WriteLine(shipper.ListItems());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
                {
                    Console.Clear();
                    Console.WriteLine(shipper.GetShippingCharges());
                    optOut = true;
                }
            }

            Console.WriteLine("Press any key to terminate");
            Console.ReadKey();
        }
    }
}
