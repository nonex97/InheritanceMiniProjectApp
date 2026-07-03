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

            Console.ReadLine();
        }
    }

    public class InventoryItemModel
    {
        public string ProductName { get; set; }

    }

    public class Vehicle : InventoryItemModel
    {
        public decimal DealerFee { get; set; }
    }

    public class BookModel : InventoryItemModel
    {
        public int NumberOfPages { get; set; }
    }
}
