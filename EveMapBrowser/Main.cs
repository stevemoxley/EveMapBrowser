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
            _mapDataGridViewPopulatorEngine = new MapDataGridViewPopulatorEngine(dgvResults);
            _mapDataGridViewPopulatorEngine.LoadDataGridView();
            btnPvp.Enabled = true;
        }

        private void btnPvp_Click(object sender, EventArgs e)
        {
            PvpReport pvpreport = new PvpReport(_mapDataGridViewPopulatorEngine.FilteredSystems);
            pvpreport.Show();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtMaxSec.Clear();
            txtMinSec.Clear();

            _mapDataGridViewPopulatorEngine.ClearFilter();
            _mapDataGridViewPopulatorEngine.LoadDataGridView();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            decimal? minSec = null;
            decimal? maxSec = null;

            if(!string.IsNullOrEmpty(txtMinSec.Text))
            {
                decimal minSecTemp = 0;
                if(!decimal.TryParse(txtMinSec.Text, out minSecTemp))
                {
                    MessageBox.Show("Please enter a valid value for min sec");
                }
                else
                {
                    minSec = minSecTemp;
                }
            }
            if (!string.IsNullOrEmpty(txtMaxSec.Text))
            {
                decimal maxSecTemp = 0;
                if (!decimal.TryParse(txtMaxSec.Text, out maxSecTemp))
                {
                    MessageBox.Show("Please enter a valid value for max sec");
                }
                else
                {
                    maxSec = maxSecTemp;
                }
            }

            _mapDataGridViewPopulatorEngine.FilterSystems(minSec, maxSec);
            _mapDataGridViewPopulatorEngine.LoadDataGridView();
        }

        private MapDataGridViewPopulatorEngine _mapDataGridViewPopulatorEngine;

   
    }
}
