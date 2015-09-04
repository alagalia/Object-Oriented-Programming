using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop lenovo = new Laptop(
                "Lenovo Yoga 2 Pro",
                "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8,
                "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                new Battery("Li Ion", 4, 3500), 4.5, 2259.00m);
           
            // string model, string processor, int ram, string hdd, decimal price
            Laptop toshiba = new Laptop("Lenovo Yoga 2 Pro",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                -8,
                "128GB SSD", 
                600.00m);
            
            Console.WriteLine(lenovo);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(toshiba);
        }
    }
}
