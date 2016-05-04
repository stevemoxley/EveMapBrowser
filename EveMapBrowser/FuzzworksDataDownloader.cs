using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    public static class FuzzworksDataDownloader
    {
        public static void DownloadData(int systemId)
        {
            WebClient client = new WebClient();
            byte[] data = client.DownloadData(string.Format(_downloadUrl, systemId));
            string dataJson = Encoding.ASCII.GetString(data);

            if(!Directory.Exists(@"cache"))
            {
                Directory.CreateDirectory(@"cache");
            }

            string fullPath = string.Format(_cacheFilePathFormat, systemId);
            if (!File.Exists(fullPath))
            {
                File.WriteAllText(fullPath,dataJson);
            }


        }

        private static string _downloadUrl = "https://www.fuzzwork.co.uk/api/mapdata.php?solarsystemid={0}&format=json";
        private static string _cacheFilePathFormat = @"cache/{0}.txt";
    }
}
