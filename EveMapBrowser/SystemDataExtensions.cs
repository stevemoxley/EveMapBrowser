using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    public static class SystemDataExtensions
    {
        public static bool HasAsteroidBelts(this SystemData systemData, int numberOfAsteroidBelts)
        {
            var asteroidBelts = systemData.SystemItems.Where(i => i.typename.ToLower().Contains("asteroid"));
            if (asteroidBelts.Count() >= numberOfAsteroidBelts)
            {
                return true;
            }
            return false;
        }

        public static string Name(this SystemData systemData)
        {
            return systemData.SystemItems.FirstOrDefault().solarsystemname;
        }
    }
}
