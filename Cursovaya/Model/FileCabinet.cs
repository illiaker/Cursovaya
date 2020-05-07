using Cursovaya.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    class FileCabinet
    {
        public FileCabinet(List<Criminal> criminals, List<CriminalGang> criminalGangs)
        {
            Criminals = criminals;
            CriminalGangs = criminalGangs;
        }

        //Картотека = коллекция преступников + колекция банд




        public List<Criminal> Criminals { get; set; }
        public List<CriminalGang> CriminalGangs { get; set; }

        public void GenerateData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Criminals.Add(new Criminal($"name{i}", $"surname{i}", $"alias{i}", i * 20,
                    $"hair_color{i}", $"eye_color{i}", i * 5, $"gender{i}", $"nationality{i}",
                    null, $"adress{i}", $"lastAdress{i}", $"profession{i}", $"country_where_wanted{i}",
                    null));
            }

            for (int i = 0; i < n; i++)
            {
                CriminalGangs.Add(new CriminalGang()
                {

                });
            }

        }

        public void Add(CriminalGang gang)
        {
            CriminalGangs.Add(gang);
        }
        public void Add(Criminal criminal)
        {
            Criminals.Add(criminal);
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
