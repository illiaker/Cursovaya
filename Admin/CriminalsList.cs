using Admin.Presenter;
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
        public CriminalsList(List<IDisplayedCriminal> criminals)
        {
            InitializeComponent();            
            GangMembers = new List<IDisplayedCriminal>();
            CriminalsToSelect = criminals;
            criminalList.DataSource = criminalBindingSourse;
            criminalBindingSourse.DataSource = criminals;
            var i = criminalList.Columns[0] as DataGridViewImageColumn;
            i.ImageLayout = DataGridViewImageCellLayout.Zoom;
            criminalBindingSourse.ResetBindings(false);
        }

        #region Properties
        public List<IDisplayedCriminal> GangMembers { get; set; }
        List<IDisplayedCriminal> CriminalsToSelect { get; set; }
        public BindingSource CBS { get => criminalBindingSourse; set => criminalBindingSourse = value; }
        #endregion

        #region EventHandlers
        private void selectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in criminalList.SelectedRows)
            {
                Criminal c = (Criminal)r.DataBoundItem;
                GangMembers.Add(c);
                CriminalsToSelect.Remove(c);
            }
            CBS.DataSource = CriminalsToSelect;
            criminalBindingSourse.ResetBindings(false);
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
                List<IDisplayedCriminal> displayedCriminals = new List<IDisplayedCriminal>();
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
                List<IDisplayedCriminal> displayedCriminals = new List<IDisplayedCriminal>();
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
