using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya.DAL
{
    [Serializable]
    //Клас, який відповідає за сериалізацію даных 
    public class Dao
    {
        private FileCabinet  fileCabinet;
        const string filePath = "fileCabinet.bin";
        //Конструктор, який приймає на вхід екззкмпляр класу FileCabinet
        public Dao(FileCabinet store)
        {
            fileCabinet = store;
        }

       
        //Метод сериалізації
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, fileCabinet);
            }
        }
        //Метод десериалізації
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                FileCabinet st = (FileCabinet)serializer.Deserialize(stream);
                Copy(st.Criminals, fileCabinet.Criminals);
                Copy(st.CriminalGangs, fileCabinet.CriminalGangs);
                Copy(st.Archive, fileCabinet.Archive);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
