using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveMapBrowser
{
    public class SystemData
    {
        public List<SystemItem> SystemItems { get; set; }

        public SystemData()
        {
            SystemItems = new List<SystemItem>();
        }
    }
}
