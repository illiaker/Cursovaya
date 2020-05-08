using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    [Serializable]
    public class Criminal
    {
        
        public Bitmap Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Alias { get; set; }
        public int Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDay { get; set; }      
        
        public string Adress { get; set; }
        public string LastAdress { get; set; }
        public string Description { get; set; }
        public string CountryWhereWanted { get; set; }
        public CriminalGang Gang{ get; set; }
        public Guid Id { get; set; }

        


       
    }
}
