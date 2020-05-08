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
       

        public CriminalInfo(Criminal criminal, bool isUser)
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
            professionBox.Text = Criminal.Description;
            countryWhereWantedBox.SelectedItem = Criminal.CountryWhereWanted;
            ganglabel.Text = Criminal.Gang != null ? Criminal.Gang.Name : "None";
            
            if (isUser)
            {
                foreach (Control i in Controls)
                {
                    TextBox t = i as TextBox;
                    if (t != null)
                    {
                        t.ReadOnly = true;

                    }
                    ComboBox c = i as ComboBox;
                    if (c != null)
                    {
                        c.Enabled = false;
                    }
                    NumericUpDown n = i as NumericUpDown;
                    if (n != null)
                    {
                        n.ReadOnly = true;
                    }
                    DateTimePicker d = i as DateTimePicker;
                    if (d != null)
                    {
                        d.Enabled = false;
                    }
                    GroupBox g = i as GroupBox;
                    if (g != null)
                    {
                        foreach (Control j in g.Controls)
                        {
                            TextBox tb = j as TextBox;
                            if (tb != null)
                            {
                                tb.ReadOnly = true;

                            }
                            RichTextBox rb = j as RichTextBox;
                            if (rb != null)
                            {
                                rb.ReadOnly = true;

                            }
                        }
                    }


                }
                label.Hide();
                IdLable.Hide();
                OpenImage.Hide();
                saveButton.Hide();
                chooseButton.Hide();
            }
            else
            {
                label.Show();
                IdLable.Show();
                IdLable.Text = Criminal.Id.ToString();
            }
            
           

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
                Criminal.Description = professionBox.Text;
                Criminal.CountryWhereWanted = (string)countryWhereWantedBox.SelectedItem;
                Criminal.Id = Guid.NewGuid(); 
            }
            
        }

        private void ganglabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Criminal.Gang != null)
            {
                new GangInfo(Criminal.Gang, true).ShowDialog();
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
