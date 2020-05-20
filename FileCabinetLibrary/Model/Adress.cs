using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    [Serializable]
    public class Adress
    {
        public string City{ get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public Adress(string city, string street, string house)
        {
            City = city;
            Street = street;
            House = house;
        }

    }
}
