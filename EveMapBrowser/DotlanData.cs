using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    public class DotlanData
    {
        public string SecStatus { get; private set; }

        public string OneHourJumps { get; set; }
        
        public string TwentyFourHourJumps { get; set; }

        public DotlanData(string systemName)
        {
            _systemName = systemName;
        }

        private void DownloadData()
        {

        }

        private string _systemName;
        private readonly string _dotlanUrl = "http://evemaps.dotlan.net/system/{0}";
    }

    
}
