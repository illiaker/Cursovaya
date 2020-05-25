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
       

        public void GenerateMembers(int n)
        {
            GenerateCriminals(n);
            GenerateArchive(n);
            GenerateGang(n);
        }
        private void GenerateGang(int n)
        {
            CriminalGangs = new List<CriminalGang>();
            for(int i = 0; i < n;i++)
            {
                var c = new CriminalGang()
                {
                    Image = new Bitmap("D:/Project/C#/OOP/Cursova/Cursovaya/Images/1.png"),
                    Name = $"Gang{i}",
                    Features = $"Features{i}",
                    FoundationDate = DateTime.Now - TimeSpan.FromDays(i * 365),
                    Country = ""

                };
                CriminalGangs.Add(c);
            }
        }
        private void GenerateCriminals(int n)
        {
            Criminals = new List<Criminal>();
            
            for (int i = 0; i < n;i++)
            {
                
                var c = new Criminal()
                {
                    Image = new Bitmap("D:/Project/C#/OOP/Cursova/Cursovaya/Images/criminal.png"),
                    Name = $"Name{i}",
                    Surname = $"Surname{i}",
                    Alias = $"Alias{i}",
                    Height = i,
                    Gender = "Other",
                    Nationality = "",
                    BirthDay = DateTime.Now - TimeSpan.FromDays(i * 365),
                    Description = $"Description{i}" 
                };
                Criminals.Add(c);
            }
        }
        private void GenerateArchive(int n)
        {
            Archive = new List<Criminal>();
            for (int i = 50; i < n + 50; i++)
            {
                var c = new Criminal()
                {
                    Image = new Bitmap("D:/Project/C#/OOP/Cursova/Cursovaya/Images/criminal.png"),
                    Name = $"Name{i}",
                    Surname = $"Surname{i}",
                    Alias = $"Alias{i}",
                    Height = i,
                    Gender = "Other",
                    Nationality = "",
                    BirthDay = DateTime.Now - TimeSpan.FromDays(i * 365),
                    Description = $"Description{i}"
                };
                Archive.Add(c);
            }
        }




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
        
        public List<Criminal> GetGanglessCriminals()
        {
            List<Criminal> res = new List<Criminal>();
            foreach(Criminal c in Criminals)
            {
                if (c.Gang == null)
                {
                    res.Add(c);
                }               
            }
            return res;
        }
       
        public List<Criminal> Search(string surname)
        {
            surname = surname.ToLower();
            List<Criminal> res = new List<Criminal>();
            foreach (Criminal c in Criminals)
            {
                if (c.Surname.ToLower().Contains(surname))
                {
                    res.Add(c);
                }
            }
            return res;
        }
        public List<Criminal> Nationality(string nationality)
        {
            List<Criminal> res = new List<Criminal>();
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
