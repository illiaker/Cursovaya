using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    public interface IDisplayedCriminal
    {
        Bitmap Image { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Alias { get; set; }
        string Gender { get; set; }
        string Nationality { get; set; }
        DateTime BirthDay { get; set; }   
        string Description { get; set; }        
        
    }
}
