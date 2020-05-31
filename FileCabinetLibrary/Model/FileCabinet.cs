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
    //Клас у якому зберігаються колекції злочинців, архівних злочинців та злочинних угруповань
    
    public class FileCabinet
    {
        
        static private FileCabinet fileCabinet;
        //Возвращает текущий екземпляр класса
        static public FileCabinet GetInstance()
        {
            if (fileCabinet == null) // если текущий екзепляр еще не создан, то создаем его
            {
                fileCabinet = new FileCabinet();
            }

            return fileCabinet; 
        }

        //Конструктор
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
       
        //Метод для генерации тестовых данных
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
                    Name = $"Name{i}",
                    Surname = $"Surname{i}",
                    Alias = $"Alias{i}",
                    Height = i,
                    Gender = "Other",
                    Nationality = null,
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
                    Name = $"Name{i}",
                    Surname = $"Surname{i}",
                    Alias = $"Alias{i}",
                    Height = i,
                    Gender = "Other",
                    Nationality = null,
                    BirthDay = DateTime.Now - TimeSpan.FromDays(i * 365),
                    Description = $"Description{i}"
                };
                Archive.Add(c);
            }
        }



        //Метод перемещания преступника в архив
        public void MoveToArchive(Criminal criminal)
        {
            Criminals.Remove(criminal);
            Archive.Add(criminal);
        }
        //Метод перемещения преступника в коллекцию текущих из архива
        public void MoveToList(Criminal criminal)
        {
            Criminals.Add(criminal);
            Archive.Remove(criminal);
       }        
       
        //Метод возвращает всех преступников у которые не состоят в преступных групировках
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
       
        //Производит поиск преступников из данного списка по определенным критериям(фамилии, имени, кличке)
        public List<Criminal> Search(string value, string criteria, List<Criminal> list)
        {
            value = value.ToLower();
            List<Criminal> res = new List<Criminal>();
            switch (criteria)
            {
                case "Surname":
                    foreach(Criminal i in list)
                    {
                        if(i.Surname.ToLower().StartsWith(value))
                        {
                            res.Add(i);
                        }
                    }
                    break;
                    
                case "Name":
                    foreach (Criminal i in list)
                    {
                        if (i.Name.ToLower().StartsWith(value))
                        {
                            res.Add(i);
                        }
                    }
                    break;
                    
                case "Alias":
                    foreach (Criminal i in list)
                    {
                        if (i.Alias.ToLower().StartsWith(value))
                        {
                            res.Add(i);
                        }
                    }
                    break;
                                  
            }
            return res;

           
        }


        //Сохраняет данные
        public void Save()
        {
            new Dao(fileCabinet).Save();
        }
        //Загружает данные
        public void Load()
        {
            new Dao(fileCabinet).Load();
        }
    }
}
