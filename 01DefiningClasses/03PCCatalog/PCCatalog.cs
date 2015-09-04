using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
           
            List<Computer> catalog = new List<Computer>();
            List<Components> components1 = new List<Components>();

            Components monitor = new Components("Monitor: Samsung", 150);
            components1.Add(monitor);
            Components mouse = new Components("Mouse: Canyon", 20);
            components1.Add(mouse);
            Components hdd = new Components("HDD: Corsair", 60);
            components1.Add(hdd);

            Computer pc1 = new Computer("MyHomePC", components1, 2000.00m);
            catalog.Add(pc1);


            List<Components> components2 = new List<Components>();
            components2.Add(new Components("Monitor: Lenovo", 50));
            components2.Add(new Components("Video Card: GForce", 10));
            components2.Add(new Components("HDD: HP", 20));
            Computer pc2 = new Computer("Office PC", components2, 1534.40m);
            catalog.Add(pc2);

            var sortedByPrize = catalog.OrderBy(c => c.Price).ToList();
            foreach (var pc in catalog)
            {
                Console.WriteLine(pc);
                Console.WriteLine();
            }
        }
    }
}
