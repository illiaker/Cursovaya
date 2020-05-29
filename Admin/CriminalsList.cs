
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
    //Класс для отобраения списка преступников
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
        //Хранит коллекцию преступников, которая в дальнейшем послужит коллекцией членов определенной преступной групировки
        public List<Criminal> GangMembers { get; set; }
        //Коллекция которая отображается на форме
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

        
        #endregion

        
    }
}
