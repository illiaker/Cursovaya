
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

namespace Admin
{
    public partial class CriminalsList : Form
    {        
        //Constructor
        public CriminalsList(List<Criminal> criminals)
        {
            InitializeComponent();            
            GangMembers = new List<Criminal>();
            CriminalsToSelect = criminals;
            criminalList.DataSource = criminalBindingSource;
            criminalBindingSource.DataSource = criminals;
            var i = criminalList.Columns[0] as DataGridViewImageColumn;
            i.ImageLayout = DataGridViewImageCellLayout.Zoom;
            criminalBindingSource.ResetBindings(false);
        }

        #region Properties
        public List<Criminal> GangMembers { get; set; }
        List<Criminal> CriminalsToSelect { get; set; }
        public BindingSource CBS { get => criminalBindingSource; set => criminalBindingSource = value; }
        #endregion

        #region EventHandlers
        private void selectButton_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow r in criminalList.SelectedRows)
            {
                Criminal c = r.DataBoundItem as Criminal;
                GangMembers.Add(c);
            }
            foreach(Criminal i in GangMembers)
            {
                CriminalsToSelect.Remove(i);
            }
            CBS.DataSource = CriminalsToSelect;
            criminalBindingSource.ResetBindings(false);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                CBS.DataSource = CriminalsToSelect;
                CBS.ResetBindings(false);
            }
            else
            {
                List<Criminal> displayedCriminals = new List<Criminal>();
                foreach (Criminal c in CriminalsToSelect)
                {
                    if (c.Surname.Contains(searchBox.Text))
                    {
                        displayedCriminals.Add(c);
                    }
                }
                CBS.DataSource = displayedCriminals;
                CBS.ResetBindings(false);
            }
        }

        private void nationalityBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((string)nationalityBox.SelectedItem))
            {
                CBS.DataSource = CriminalsToSelect;
                CBS.ResetBindings(false);
            }
            else
            {
                List<Criminal> displayedCriminals = new List<Criminal>();
                foreach (Criminal c in CriminalsToSelect)
                {
                    if (c.Nationality == (string)nationalityBox.SelectedItem)
                    {
                        displayedCriminals.Add(c);
                    }
                }
                CBS.DataSource = displayedCriminals;
                CBS.ResetBindings(false);
            }
        }
        #endregion

        
    }
}
