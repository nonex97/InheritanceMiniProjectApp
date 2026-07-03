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

            inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" });
            inventory.Add(new BookModel { ProductName = "A tale of two Cities", NumberOfPages = 350 });

            Console.ReadLine();
        }
    }

    public class InventoryItemModel
    {
        public string ProductName { get; set; }

    }

    public class VehicleModel : InventoryItemModel
    {
        public decimal DealerFee { get; set; }
    }

    public class BookModel : InventoryItemModel
    {
        public int NumberOfPages { get; set; }
    }

    public class Excavator : InventoryItemModel
    {
        public void Dig()
        {
            Console.WriteLine("I am digging.");
        }
    }
}
