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
            Criminals = new List<IDisplayedCriminal>();
            CriminalGangs = new List<CriminalGang>();
            Archive = new List<IDisplayedCriminal>();
        }
        //Картотека = коллекция преступников + колекция банд

        public List<IDisplayedCriminal> Archive { get; set; }
        public List<IDisplayedCriminal> Criminals { get; set; }
        public List<CriminalGang> CriminalGangs { get; set; }        
       

       




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
        
        public List<IDisplayedCriminal> GetGanglessCriminals()
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
       
        public List<IDisplayedCriminal> Search(string surname)
        {
            surname = surname.ToLower();
            List<IDisplayedCriminal> res = new List<IDisplayedCriminal>();
            foreach (Criminal c in Criminals)
            {
                if (c.Surname.ToLower().Contains(surname))
                {
                    res.Add(c);
                }
            }
            return res;
        }
        public List<IDisplayedCriminal> Nationality(string nationality)
        {
            List<IDisplayedCriminal> res = new List<IDisplayedCriminal>();
            foreach (Criminal c in Criminals)
            {
                if (c.Nationality==nationality)
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
