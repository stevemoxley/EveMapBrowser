using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    public static class SystemDataProvider
    {
        public static List<SystemData> GetSystemData()
        {
            List<SystemData> systemData = new List<SystemData>();

            var cachedFilePaths = Directory.EnumerateFiles(cacheDirectory);

            foreach (var cachedFilePath in cachedFilePaths)
            {
                var json = File.ReadAllText(cachedFilePath);

                List<SystemItem> jsonObject = JsonConvert.DeserializeObject<List<SystemItem>>(json);

                SystemData data = new SystemData();
                data.SystemItems = jsonObject;

                systemData.Add(data);              
            }

            return systemData;
        }

        private static string cacheDirectory = @"cache";
    }
}
