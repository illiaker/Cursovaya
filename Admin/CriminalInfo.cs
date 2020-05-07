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
    public partial class CriminalInfo : Form
    {

        public Criminal Criminal { get; private set; }
        public CriminalInfo()
        {
            InitializeComponent();
            Criminal = new Criminal();
            
        }

        public bool IsChanged { get; set; } = false;

        public CriminalInfo(Criminal criminal)
        {
            InitializeComponent();
            Criminal = criminal;
            nameBox.Text = Criminal.Name;
            CriminalImage.Image = Criminal.Image;
            surnameBox.Text = Criminal.Surname;
            aliasBox.Text = Criminal.Alias;
            heightBox.Value = Criminal.Height;
            ageBox.Value = Criminal.Age;
            genderBox.SelectedItem = Criminal.Gender;
            nationalityBox.SelectedItem = Criminal.Nationality;
            birthdayBox.Value = Criminal.BirthDay;
            professionBox.Text = Criminal.Profession;
            countryWhereWantedBox.SelectedItem = Criminal.CountryWhereWanted;
            ganglabel.Text = Criminal.Gang != null ? Criminal.Gang.Name : "None"; 

        }
        private void OpenImage_Click(object sender, EventArgs e)
        {
            ChooseCriminalImage.ShowDialog();
            try
            {
                CriminalImage.Image = Image.FromFile(ChooseCriminalImage.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File '{ex.Message}' was not found", "Error!!!");
            }
        }

        private void CriminalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == DialogResult)
            {
                Criminal.Name = nameBox.Text;
                Criminal.Image = (Bitmap)CriminalImage.Image;
                Criminal.Surname = surnameBox.Text;
                Criminal.Alias = aliasBox.Text;
                Criminal.Height = (int)heightBox.Value;
                Criminal.Age = (int)ageBox.Value;
                Criminal.Gender = (string)genderBox.SelectedItem;
                Criminal.Nationality = (string)nationalityBox.SelectedItem;
                Criminal.BirthDay = birthdayBox.Value;
                Criminal.Profession = professionBox.Text;
                Criminal.CountryWhereWanted = (string)countryWhereWantedBox.SelectedItem;
            }
            
        }

        private void CriminalInfo_TextChanged(object sender, EventArgs e)
        {
            IsChanged = true;
        }
    }
}
