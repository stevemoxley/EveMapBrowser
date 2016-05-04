using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    public static class SystemProvider
    {
        public static List<int> GetSystemIds()
        {
            List<int> systemIds = new List<int>();

            var systems = File.ReadAllLines(@"systems.txt");

            foreach (var system in systems)
            {
                var systemParts = system.Split('|');
                systemIds.Add(int.Parse(systemParts[1].ToString()));
            }

            return systemIds;
        }
    }
}
