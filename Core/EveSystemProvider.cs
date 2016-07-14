using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Core
{
    public static class EveSystemProvider
    {
        public static List<EveSystem> GetSystemsFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            var result = new List<EveSystem>();

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                EveSystem system = new EveSystem
                {
                    Id = long.Parse(parts[1]),
                    Name = parts[0]
                };

                result.Add(system);
            }

            return result;
        }

        private static string filePath = @"systems.txt";

    }
}
