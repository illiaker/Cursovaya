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
        public CriminalGang()
        {
            GangMambers = new List<Criminal>();
            EnemyGangs = new List<CriminalGang>();
            AllyGang = new List<CriminalGang>();
            Id = Guid.NewGuid();
        }
        public Bitmap Image { get; set; }
        public string Name { get; set; }
        public List<Criminal> GangMambers { get; set; }
        public List<CriminalGang> EnemyGangs { get; set; }
        public List<CriminalGang> AllyGang { get; set; }
        public string Features { get; set; }
        public DateTime FoundationDate { get; set; }
        public Criminal Leader { get; set; }
        public string Country { get; set; }         
        public Guid Id { get; private set; }

        public string LeaderName
        {
            get
            {
                return Leader == null ? " " : Leader.Name + " " + Leader.Surname;
                
            }
        } 
        
    }
}
