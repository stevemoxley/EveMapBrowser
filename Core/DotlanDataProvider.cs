using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Web;
using System.Net;

namespace Core
{
    public static class DotlanDataProvider
    {

        public static void GetSystemData(EveSystem eveSystem)
        {
            try
            {
                if (string.IsNullOrEmpty(eveSystem.Name))
                {
                    return;
                }

                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = new HtmlDocument();
                var html = DotlanHTMLProvider.GetHTML(eveSystem.Name);
                doc.LoadHtml(html);

                var table = doc.DocumentNode.Descendants("table").Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("tablelist"));

                var infoTable = table.ElementAt(0);

                var jumpsLine = infoTable.ChildNodes[1].InnerText;
                var shipsKilledLine = infoTable.ChildNodes[3].InnerText;
                var beltsLine = infoTable.ChildNodes[5].InnerText;
                var secLine = infoTable.ChildNodes[7].InnerText;
                var factionLine = infoTable.ChildNodes[9].InnerText;

                var jumpsParts = SplitTableString(jumpsLine);
                var shipsKilledParts = SplitTableString(shipsKilledLine);
                var beltsParts = SplitTableString(beltsLine);
                var secParts = SplitTableString(secLine);
                var factionParts = SplitTableString(factionLine);

                eveSystem.Jumps1Hour = int.Parse(jumpsParts[6]);
                eveSystem.Jumps24Hours = int.Parse(jumpsParts[7]);

                eveSystem.ShipsKilled1Hour = int.Parse(shipsKilledParts[6]);
                eveSystem.ShipsKilled24Hours = int.Parse(shipsKilledParts[7]);

                eveSystem.PodsKilled1Hour = int.Parse(secParts[6]);
                eveSystem.PodsKilled24Hours = int.Parse(secParts[7]);

                eveSystem.RatsKilled1Hour = int.Parse(beltsParts[6]);
                eveSystem.RatsKilled24Hours = int.Parse(beltsParts[7]);

                eveSystem.Region = shipsKilledParts[2].Trim();

                string beltsString = beltsParts[4];
                var beltsStringParts = beltsString.Split('+');

                eveSystem.NumberOfBelts = int.Parse(beltsStringParts[0]);

                eveSystem.SecurityStatus = decimal.Parse(secParts[2]);

                eveSystem.Faction = WebUtility.HtmlDecode(factionParts[2].Trim());
            }
            catch (Exception ex)
            {

            }
        }

        private static string[] SplitTableString(string tableString)
        {
            return tableString.Split(new string[] { "\n" }, StringSplitOptions.None);
        }



    }
}
