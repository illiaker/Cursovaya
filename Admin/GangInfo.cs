using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminView
{
    public partial class GangInfo : Form
    {
        public GangInfo()
        {
            InitializeComponent();
            Gang = new CriminalGang();
        }
        public CriminalGang Gang { get; set; }
        public GangInfo(CriminalGang gang, bool isUser)
        {
            InitializeComponent();
            Gang = gang;
        }

        private void imageChoseButton_Click(object sender, EventArgs e)
        {
            choseimageDialog.ShowDialog();
            try
            {
                gangImageBox.Image = new Bitmap(choseimageDialog.FileName);
            }
            catch(Exception)
            {
                MessageBox.Show("There is no such file");
            }
        }
    }
}
