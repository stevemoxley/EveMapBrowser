using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class EveSystem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int Jumps1Hour { get; set; }

        public int Jumps24Hours { get; set; }

        public decimal SecurityStatus { get; set; }

        public int NumberOfBelts { get; set; }

        public string Faction { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2} Belts | {3} | {4}/{5}", Name, SecurityStatus, NumberOfBelts, Faction, Jumps1Hour, Jumps24Hours);
        }
    }

}
