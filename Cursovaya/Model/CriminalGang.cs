using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    class CriminalGang
    {
        public string Name { get; set; }
        public List<Criminal> GangMambers { get; set; }
        public List<CriminalGang> EnemyGangs { get; set; }
        public List<CriminalGang> AllyGang { get; set; }
        public string Features { get; set; }


        public string Country { get; set; }                          
    }
}
