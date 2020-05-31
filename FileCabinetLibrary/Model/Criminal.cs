
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    [Serializable]
    //Клас злочинця в якому зберігається вся відома інформація про злочинця
    public class Criminal
    {
        public Criminal()
        {
            Id = Guid.NewGuid();
        }
        public Bitmap Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Alias { get; set; }
        public int Height { get; set; }
        public int Age
        { 
            get
            {
                var i = DateTime.Now.Year - BirthDay.Year;
                if (DateTime.Now.DayOfYear - BirthDay.DayOfYear < 0)
                {
                    i--;
                }
                return i;
                   
            }
        }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDay { get ; set ; }
        public string Date { get => BirthDay.ToShortDateString(); }
        public Adress Adress { get; set; }
        public Adress LastAdress { get; set; }
        public string Description { get; set; }
        public string CountryWhereWanted { get; set; }
        public CriminalGang Gang{ get; set; }
        public Guid Id { get;private set; }
    }
}
