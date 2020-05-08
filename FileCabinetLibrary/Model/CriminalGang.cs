using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    [Serializable]
    public class CriminalGang
    {
        public Bitmap Image { get; set; }
        public string Name { get; set; }
        public List<Criminal> GangMambers { get; set; }
        public List<CriminalGang> EnemyGangs { get; set; }
        public List<CriminalGang> AllyGang { get; set; }
        public string Features { get; set; }
        public DateTime FoundationDate { get; set; }
        public Criminal Leader { get; set; }
        public string Country { get; set; }                          
    }
}
