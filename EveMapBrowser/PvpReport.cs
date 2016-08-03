using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveMapBrowser
{
    public partial class PvpReport : Form
    {


        public PvpReport(List<EveSystem> eveSystems)
        {
            InitializeComponent();

            _eveSystems = eveSystems;
        }

        private void PvpReport_Load(object sender, EventArgs e)
        {
            LoadViolentRegions();
        }

        private void LoadViolentRegions()
        {
            var systemsGrouping = from s in _eveSystems
                                  group s by s.Region into g
                                  select new
                                  {
                                      Region = g.Key,
                                      Sum = g.Sum(t => t.ShipsKilled24Hours)
                                  };

            systemsGrouping = systemsGrouping.OrderByDescending(t => t.Sum);

            var systemsGroupingArray = systemsGrouping.ToArray();

            string[] infoStrings = new string[systemsGroupingArray.Length];

            for (int i = 0; i < infoStrings.Length; i++)
            {
                var group = systemsGroupingArray[i];
                infoStrings[i] = string.Format("{0} - {1}", group.Region, group.Sum);
            }

            lstViolentRegions.Items.AddRange(infoStrings);

        }

        private List<EveSystem> _eveSystems;
    }
}
