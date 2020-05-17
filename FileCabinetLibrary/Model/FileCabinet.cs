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
        static private FileCabinet fileCabinet;
        static public FileCabinet GetInstance()
        {
            if (fileCabinet == null)
            {
                fileCabinet = new FileCabinet();
            }

            return fileCabinet;
        }

       
        protected FileCabinet()
        {
            Criminals = new List<Criminal>();
            CriminalGangs = new List<CriminalGang>();
            Archive = new List<Criminal>();
        }
        //Картотека = коллекция преступников + колекция банд

        public List<Criminal> Archive { get; set; }
        public List<Criminal> Criminals { get; set; }
        public List<CriminalGang> CriminalGangs { get; set; }

        
        public List<IDisplayedCriminal> GetCriminals()
        {
            List<IDisplayedCriminal> res = new List<IDisplayedCriminal>();
            foreach(Criminal c in Criminals)
            {
                res.Add(c);

            }
            return res;
        }



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
        public void Add(Criminal criminal)
        {
            Criminals.Add(criminal);
        }
        
        public List<IDisplayedCriminal> GanglessCriminals()
        {
            List<IDisplayedCriminal> res = new List<IDisplayedCriminal>();
            foreach(Criminal c in Criminals)
            {
                if (c.Gang == null)
                {
                    res.Add(c);
                }               
            }
            return res;
        }
       
        
        public void Save()
        {
            new Dao(fileCabinet).Save();
        }
        public void Load()
        {
            new Dao(fileCabinet).Load();
           
        }
    }
}
