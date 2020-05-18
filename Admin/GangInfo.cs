using Admin;
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
            FileCabinet = FileCabinet.GetInstance();
        }
        public CriminalGang Gang { get; set; }
        public FileCabinet FileCabinet { get; set; }
        public GangInfo(CriminalGang gang)
        {
            InitializeComponent();
            Gang = gang;
            FileCabinet = FileCabinet.GetInstance();
            nameBox.Text = Gang.Name;
            foundationtimebox.Value = Gang.FoundationDate;
            countryBox.SelectedItem = Gang.Country;
            gangImageBox.Image = Gang.Image;
            featuresBox.Text = Gang.Features;
            IdLabelValue.Text = Gang.Id.ToString();
            if(User.Role == "user")
            {

            }
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

        private void GangInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                Gang.Name = nameBox.Text;
                Gang.Image = (Bitmap)gangImageBox.Image;
                Gang.FoundationDate = foundationtimebox.Value;
                Gang.Features = featuresBox.Text;
                Gang.Country = (string)countryBox.SelectedItem;                
                
            }
        }

        private void leaderChoseButton_Click(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            new CriminalsList(Gang.GangMambers).ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
           var cl = new CriminalsList(FileCabinet.GetGanglessCriminals());
            if(cl.ShowDialog() == DialogResult.OK)
            {
                
                foreach(Criminal c in cl.GangMembers)
                {
                    Gang.GangMambers.Add(c);
                    c.Gang = Gang;
                }
            }
        }
    }
}
