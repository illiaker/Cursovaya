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
       public  List<Criminal> GangMembers{ get; set; }
        List<IDisplayedCriminal> CriminalsToSelect { get; set; }
        public CriminalsList(List<IDisplayedCriminal> criminals)
        {
            InitializeComponent();
            GangMembers = new List<Criminal>();
            CriminalsToSelect = criminals;
            criminalList.DataSource = criminalBindingSourse;
            criminalBindingSourse.DataSource = criminals;
            var i = criminalList.Columns[0] as DataGridViewImageColumn;
            i.ImageLayout = DataGridViewImageCellLayout.Zoom;
            criminalBindingSourse.ResetBindings(false);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in criminalList.SelectedRows)
            {
                Criminal c = (Criminal)r.DataBoundItem;
                GangMembers.Add(c);
                CriminalsToSelect.Remove(c);
            }
            criminalBindingSourse.ResetBindings(false);
        }
    }
}
