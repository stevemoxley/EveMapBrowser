using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Core
{
    public static class CacheEngine
    {
        public static string Get(string fileName)
        {
            if (File.Exists(GetFullPath(fileName)))
            {
                return File.ReadAllText(GetFullPath(fileName));
            }
            else
            {
                return string.Empty;
            }
        }

        public static bool CacheExpired(string fileName)
        {
            if (!File.Exists(GetFullPath(fileName)))
            {
                return true;
            }

            var dateCreated = File.GetCreationTime(GetFullPath(fileName));

            var timeDifference = DateTime.Now - dateCreated;

            if (timeDifference.TotalHours >= 24)
            {
                return true;
            }

            return false;
        }

        public static void Cache(string contents, string fileName)
        {
            CreateDirectory();
            if (CacheExpired(fileName))
            {
                File.Delete(GetFullPath(fileName));
                File.WriteAllText(GetFullPath(fileName), contents);
            }
            else
            {
                File.WriteAllText(GetFullPath(fileName), contents);
            }
        }

        private static void CreateDirectory()
        {
            var workingDirectory = Path.Combine(Directory.GetCurrentDirectory(), _directoryName);
            if (!Directory.Exists(workingDirectory))
            {
                Directory.CreateDirectory(workingDirectory);
            }
        }

        private static string GetFullPath(string fileName)
        {
            var workingDirectory = Path.Combine(Directory.GetCurrentDirectory(), _directoryName);
            var path = Path.Combine(workingDirectory, fileName);
            return path;
        }

        private static string _directoryName = @"cache";

    }
}
