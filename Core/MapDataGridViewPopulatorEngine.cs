using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public class MapDataGridViewPopulatorEngine
    {

        public List<EveSystem> AllSystems { get; private set; }

        public List<EveSystem> FilteredSystems { get; private set; }

        public MapDataGridViewPopulatorEngine(DataGridView dataGridView)
        {

            FilteredSystems = new List<EveSystem>();
            _dataGridView = dataGridView;

            Load();
        }

        public void FilterSystems(decimal? minSec, decimal? maxSec)
        {
            FilteredSystems.Clear();
            FilteredSystems.AddRange(AllSystems);

            if(minSec.HasValue)
                FilteredSystems.RemoveAll(s => s.SecurityStatus < minSec.Value);

            if (maxSec.HasValue)
                FilteredSystems.RemoveAll(s => s.SecurityStatus > maxSec.Value);
        }

        private void Load()
        {
            var systems = EveSystemProvider.GetSystemsFromFile();

            AllSystems = systems;

            var taskList = new List<Task>();

            foreach (var system in systems)
            {
                taskList.Add(Task.Factory.StartNew(() => DotlanDataProvider.GetSystemData(system)));
            }

            Task.WaitAll(taskList.ToArray());
        }

        public void LoadDataGridView()
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

            List<EveSystem> eveSystems = new List<EveSystem>();
            eveSystems.AddRange(AllSystems);

            if(FilteredSystems.Count > 0)
            {
                eveSystems.Clear();
                eveSystems.AddRange(FilteredSystems);
            }

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

            _dataGridView.DataSource = dt;
            _dataGridView.Refresh();
        }

        public void ClearFilter()
        {
            FilteredSystems.Clear();
        }

        private DataGridView _dataGridView;

    }
}
