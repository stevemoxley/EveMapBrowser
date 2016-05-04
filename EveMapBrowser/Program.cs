using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading all system data...");
            var systemData = SystemDataProvider.GetSystemData();
            Console.WriteLine("Done loading system data");
            Console.WriteLine("Searching for asteroid belts");
            foreach (var system in systemData)
            {
                if (system.HasAsteroidBelts(10))
                {
                    Console.WriteLine(string.Format("Found one {0}", system.Name()));
                }
            }
            Console.ReadLine();
        }
    }
}
