using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace EveMapBrowser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var systems = EveSystemProvider.GetSystemsFromFile();

            var taskList = new List<Task>();

            foreach (var system in systems)
            {
                lstMessages.Items.Add(string.Format("Checking {0}", system.Name));
                taskList.Add(Task.Factory.StartNew(() => DotlanDataProvider.GetSystemData(system)));
            }

            Task.WaitAll(taskList.ToArray());

            lstMessages.Items.Add("Done getting all data");

            foreach (var system in systems)
            {
                if (PassesTest(system))
                {
                    lstResults.Items.Add(system);
                }
            }

        }

        private bool PassesTest(EveSystem system)
        {
            if(system.SecurityStatus > 0.8M && system.NumberOfBelts > 9)
            {
                return true;
            }

            return false;
        }
    }
}
