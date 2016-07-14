using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Core
{
    public static class DotlanDataProvider
    {
        public static void GetSystemData(EveSystem eveSystem)
        {
            try {
                if (string.IsNullOrEmpty(eveSystem.Name))
                {
                    return;
                }

                string url = string.Format(_dotlanUrl, eveSystem.Name);
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(url);

                var table = doc.DocumentNode.Descendants("table").Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("tablelist"));

                var infoTable = table.ElementAt(0);

                var jumpsLine = infoTable.ChildNodes[1].InnerText;
                var beltsLine = infoTable.ChildNodes[5].InnerText;
                var secLine = infoTable.ChildNodes[7].InnerText;
                var factionLine = infoTable.ChildNodes[9].InnerText;

                var jumpsParts = SplitTableString(jumpsLine);
                var beltsParts = SplitTableString(beltsLine);
                var secParts = SplitTableString(secLine);
                var factionParts = SplitTableString(factionLine);

                eveSystem.Jumps1Hour = int.Parse(jumpsParts[6]);
                eveSystem.Jumps24Hours = int.Parse(jumpsParts[7]);

                string beltsString = beltsParts[4];
                var beltsStringParts = beltsString.Split('+');

                eveSystem.NumberOfBelts = int.Parse(beltsStringParts[0]);

                eveSystem.SecurityStatus = decimal.Parse(secParts[2]);

                eveSystem.Faction = factionParts[2].Trim();
            }catch(Exception ex)
            {

            }
        }

        private static string[] SplitTableString(string tableString)
        {
            return tableString.Split(new string[] { "\n" }, StringSplitOptions.None);
        }


        private static string _dotlanUrl = "http://evemaps.dotlan.net/system/{0}";

    }
}
