using Admin;
using Cursovaya.Model;
using FileCabinetLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminView
{
    //Форма на которая служит для отображения, изменения или создания данных преступника 
    public partial class CriminalInfo : Form
    {

        
        //Constructors
        public CriminalInfo()
        {
            InitializeComponent();
            Criminal = new Criminal();
            
        }   
        public CriminalInfo(Criminal criminal)
        {
            
            InitializeComponent();
            Criminal = criminal;
            
            nameBox.Text = Criminal.Name;
            CriminalImage.Image = Criminal.Image;
            surnameBox.Text = Criminal.Surname;
            aliasBox.Text = Criminal.Alias;
            heightBox.Value = Criminal.Height;
            ageBox.Text = Criminal.Age.ToString();
            genderBox.SelectedItem = Criminal.Gender;
            nationalityBox.SelectedItem = Criminal.Nationality;
            birthdayBox.Value = Criminal.BirthDay;
            professionBox.Text = Criminal.Description;
            countryWhereWantedBox.SelectedItem = Criminal.CountryWhereWanted;
            ganglabel.Text = Criminal.Gang != null ? Criminal.Gang.Name : "None";
            if (Criminal.Adress != null)
            {
                cityBox.Text = Criminal.Adress.City;
                streetBox.Text = Criminal.Adress.Street;
                houseBox.Text = Criminal.Adress.House;
            }
            if (Criminal.LastAdress != null)
            {
                lastcityBox.Text = Criminal.LastAdress.City;
                lastStreetBox.Text = Criminal.LastAdress.Street;
                lastHouseBox.Text = Criminal.LastAdress.House;
            }
             // если текущий пользователь программы это обычный пользователь
             // то от него скрываются все елементы управления которые служат для изменения информации
            if (User.Role == UserRole.User)                                            
            {                                  
                foreach (Control i in Controls)
                {
                    if (i is TextBox t)
                    {
                        t.ReadOnly = true;
                    }
                    if (i is ComboBox c)
                    {
                        c.Enabled = false;
                    }
                    if (i is NumericUpDown n)
                    {
                        n.Enabled = false;
                    }
                    if (i is DateTimePicker d)
                    {
                        d.Enabled = false;
                    }
                    if (i is GroupBox g)
                    {
                        foreach (Control j in g.Controls)
                        {
                            if (j is TextBox tb)
                            {
                                tb.ReadOnly = true;

                            }
                            if (j is RichTextBox rb)
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

        #region Properties
        public Criminal Criminal { get; private set; }
        #endregion

        #region EventHandlers
        private void OpenImage_Click(object sender, EventArgs e)
        {
            ChooseCriminalImage.ShowDialog();
            try
            {
                CriminalImage.Image = Image.FromFile(ChooseCriminalImage.FileName);
            }
            catch (Exception)
            {
               
            }
        }

        private void CriminalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == DialogResult)
            {
                foreach(Control c in Controls)
                {
                    if(c is TextBox t)
                    {
                        CheckIfFilled(t, e);
                       
                    }
                    if(c is ComboBox cb)
                    {
                        CheckIfFilled(cb, e);
                        
                    }
                }

                if (e.Cancel == true)
                {
                    MessageBox.Show("You have to fill all reqiered fileds");
                }
                Criminal.Name = nameBox.Text;
                Criminal.Image = (Bitmap)CriminalImage.Image;
                Criminal.Surname = surnameBox.Text;
                Criminal.Alias = aliasBox.Text;
                Criminal.Height = (int)heightBox.Value;
                Criminal.Gender = (string)genderBox.SelectedItem;
                Criminal.Nationality = (string)nationalityBox.SelectedItem;
                Criminal.BirthDay = birthdayBox.Value;
                Criminal.Description = professionBox.Text;
                Criminal.CountryWhereWanted = (string)countryWhereWantedBox.SelectedItem;
                Criminal.Adress = new Adress(cityBox.Text, streetBox.Text, houseBox.Text);
                Criminal.LastAdress = new Adress(lastcityBox.Text, lastStreetBox.Text, lastHouseBox.Text);
            }

        }

        private void ControlOnFocus(Control cb)
        {
            cb.BackColor = Color.White;
        }

        private void CheckIfFilled(Control sender, FormClosingEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.BackColor = Color.Pink;
                e.Cancel = true;
            }
            else
            {
                sender.BackColor = Color.White;
            }
            
        }

        private void ganglabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Criminal.Gang != null)
            {
                new GangInfo(Criminal.Gang).ShowDialog();
            }
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            var gangListForm = new GangList();
            if(gangListForm.ShowDialog() == DialogResult.OK)
            {
                Criminal.Gang = gangListForm.Gang;
                gangListForm.Gang.GangMambers.Add(Criminal);
                ganglabel.Text = Criminal.Gang.Name;
            }
        }
        private void birthdayBox_ValueChanged(object sender, EventArgs e)
        {
            Criminal.BirthDay = birthdayBox.Value;
            ageBox.Text = Criminal.Age.ToString();
        }
        private void aliasBox_MouseClick(object sender, MouseEventArgs e)
        {
            ControlOnFocus((Control)sender);
        }
        #endregion


    }
}
