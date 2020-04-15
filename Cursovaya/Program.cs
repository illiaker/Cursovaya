using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursovaya
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileCabinet fileCabinet = new FileCabinet(new List<Criminal>(), new List<CriminalGang>());
            fileCabinet.GenerateData(10);
            fileCabinet.Save();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new Form1());
        }
    }
}
