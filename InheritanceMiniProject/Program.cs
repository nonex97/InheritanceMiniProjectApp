using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentalable> rentables = new List<IRentalable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Cupra Leon" };
            var book = new BookModel { ProductName = "Moby Dick", NumberOfPages = 259 };
            var excavator = new ExcavatorModel { ProductName = "JCB", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle); // we can have the same vehicle in the rentables and purchasables (it only containes the address to it)

            Console.Write("Do you want to rent or purchase something (rent, purchase): ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");

                    Console.Write("Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");

                    Console.Write("Do you want to buy this item (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.WriteLine("We are done");

            Console.ReadLine();
        }
    }
}