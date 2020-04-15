using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.Model
{
    class Criminal
    {
        public Criminal(string name, string surname, string alias, int height, string hairColor, string eyeColor, int age, string gender, string nationality, DateTime? birthDay, string adress, string lastAdress, string proffesion, string countryWhereWanted, CriminalGang gang)
        {
            Name = name;
            Surname = surname;
            Alias = alias;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Age = age;
            Gender = gender;
            Nationality = nationality;
            //BirthDay = birthDay;
            Adress = adress;
            LastAdress = lastAdress;
            Profession = proffesion;
            CountryWhereWanted = countryWhereWanted;
            Gang = gang;
        }

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
        public string Profession { get; set; }
        public string CountryWhereWanted { get; set; }
        public CriminalGang Gang{ get; set; }

        public string GetInfo()
        {
            return $"{Name}\n{Surname}\n{Alias}\n{Height}\n{HairColor}\n" +
                $"{EyeColor}\n{Age}\n{Gender}\n{Nationality}" +
                $"\n{Adress}\n{LastAdress}\n{Profession}\n{CountryWhereWanted}";
        }
    }
}
