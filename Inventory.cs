using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wood
{
    public class    Inventory
    {

        private string ProjectName;
        private string Date;
        private Dictionary<Sunta, int> stockQuantities;

        public Inventory(string projectName, string date)
        {
            ProjectName = projectName;
            Date = date;
            stockQuantities = new Dictionary<Sunta, int>();
        }
         
        public int this[Sunta sunta]
        {
            get => stockQuantities.TryGetValue(sunta, out int qty) ? qty : 0;
            set => stockQuantities[sunta] =  value;
        }


        public void PrintStockQuantities()
        {
            Console.WriteLine($"Inventory for {ProjectName} on {Date}:");
            foreach (var item in stockQuantities)
            {
                Console.WriteLine($"Sunta: Length={item.Key.Length}, Width={item.Key.Width}, Quantity={item.Value}");
            }
        }

    }
}

