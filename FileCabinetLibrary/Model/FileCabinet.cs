using Cursovaya.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    [Serializable]
    public class FileCabinet
    {
        public FileCabinet(List<Criminal> criminals, List<CriminalGang> criminalGangs)
        {
            Criminals = criminals;
            CriminalGangs = criminalGangs;
            
        }

        public FileCabinet()
        {
            Criminals = new List<Criminal>();
            CriminalGangs = new List<CriminalGang>();
            Archive = new List<Criminal>();
        }
        //Картотека = коллекция преступников + колекция банд

        public List<Criminal> Archive { get; set; }


        public List<Criminal> Criminals { get; set; }
        public List<CriminalGang> CriminalGangs { get; set; }

        //public void GenerateData(int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Criminals.Add(new Criminal
        //        {
        //            Image = new Bitmap("D:/Project/C#/OOP/Cursova/Cursovaya/Images/criminal.png"),
        //           Name = $"Name{i}",
        //           Surname = $"Surname{i}",

        //        });
                
        //    }

        //    for (int i = 0; i < n; i++)
        //    {
        //        CriminalGangs.Add(new CriminalGang()
        //        {

        //        });
        //    }

        //}

        public void MoveToArchive(Criminal criminal)
        {
            Criminals.Remove(criminal);
            Archive.Add(criminal);
        }
        public void MoveToList(Criminal criminal)
        {
            Criminals.Add(criminal);
            Archive.Remove(criminal);
        }
        public void Add(CriminalGang gang)
        {
            CriminalGangs.Add(gang);
        }
        public void Add(Criminal criminal)
        {
            Criminals.Add(criminal);
        }
        public IEnumerable<Criminal> GetCriminals()
        {
            return Criminals;
        }
        public IEnumerable<CriminalGang> GetGangs()
        {
            return CriminalGangs;
        }
        public void Save()
        {
            new Dao(this).Save();
        }
        public void Load()
        {
            new Dao(this).Load();
           
        }
    }
}
