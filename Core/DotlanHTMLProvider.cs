using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;   

namespace Core
{
    public static class DotlanHTMLProvider
    {

        public static string GetHTML(string systemName)
        {
            string fileName = GetFileName(systemName);
            string url = string.Format(_dotlanUrl, systemName);

            if (CacheEngine.CacheExpired(fileName))
            {
                var webClient = new WebClient();

                var html = webClient.DownloadString(url);

                CacheEngine.Cache(html, fileName);

                return html;
            }
            else
            {
                return CacheEngine.Get(fileName);
            }
        }

        private static string GetFileName(string systemName)
        {
            return string.Format("{0}.html", systemName);
        }


        private static string _dotlanUrl = "http://evemaps.dotlan.net/system/{0}";

    }
}
