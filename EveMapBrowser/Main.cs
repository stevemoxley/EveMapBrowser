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

            List<EveSystem> results = new List<EveSystem>();

            foreach (var system in systems)
            {
                if (PassesTest(system))
                {
                    results.Add(system);
                }
            }

            LoadDataGridView(results);

        }

        private bool PassesTest(EveSystem system)
        {
            if(system.SecurityStatus > 0.8M && system.NumberOfBelts > 9)
            {
                return true;
            }

            return false;
        }

        private void LoadDataGridView(List<EveSystem> eveSystems)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Security Status");
            dt.Columns.Add("Belts");
            dt.Columns.Add("1 Hr Jumps");
            dt.Columns.Add("24 Hr Jumps");
            dt.Columns.Add("Faction");

            dt.Columns[0].DataType = typeof(string);
            dt.Columns[1].DataType = typeof(decimal);
            dt.Columns[2].DataType = typeof(int);
            dt.Columns[3].DataType = typeof(int);
            dt.Columns[4].DataType = typeof(int);
            dt.Columns[5].DataType = typeof(string);

            foreach (var system in eveSystems)
            {
                var row = dt.NewRow();
                row[0] = system.Name;
                row[1] = system.SecurityStatus;
                row[2] = system.NumberOfBelts;
                row[3] = system.Jumps1Hour;
                row[4] = system.Jumps24Hours;
                row[5] = system.Faction;
                dt.Rows.Add(row);
            }

            dgvResults.DataSource = dt;
        }

    }
}
