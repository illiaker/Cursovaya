using Admin;
using Admin.Presenter;
using AdminView.Presenter;
using Cursovaya.Model;
using FileCabinetLibrary.Model;
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
    public partial class ListMenu : Form, ISort
    {
        public ListMenu()
        {
            InitializeComponent();
            new ListMenuPresenter(this);
            new SortPresenter(this);
            criminalsDataGridView.AutoGenerateColumns = false;
            gangGridView.AutoGenerateColumns = false;
            archiveDataGridView.AutoGenerateColumns = false;
        }
        #region Events
        public event EventHandler LoadEvent = null;

        public event EventHandler OnUserCahngeEvent = null;

        public event EventHandler AddCriminalEvent = null;

        public event EventHandler SaveEvent;

        public event EventHandler MoveToArchiveEvent;

        public event EventHandler MoveToListevent = null;        

        public event KeyEventHandler AutorizationEvent;

        public event EventHandler AddGangEvent;

        public event EventHandler DeleteEvent;

        public event EventHandler SearchEvent;

        public event EventHandler ResetEvent;

        public event EventHandler NationalityChangedEvent;
        
        #endregion

        #region Properties
        public MenuStrip MenuStrip { get => adminMenuStrip; set => adminMenuStrip = value; }
        public DataGridView List { get { return criminalsDataGridView; } set { criminalsDataGridView = value; } }
        public DataGridView GangList { get => gangGridView; set => gangGridView = value; }
        public DataGridView ArchiveList { get { return archiveDataGridView; } set { archiveDataGridView = value; } }
        public BindingSource ABS { get =>archiveBindingSource ; set => archiveBindingSource = value; }
        public BindingSource GBS { get => criminalGangBindingSource; set => criminalGangBindingSource = value; }
        public BindingSource CBS { get => criminalBindingSource; set => criminalBindingSource = value; }

        #endregion

        #region EventHandlers
        private void ListMenu_Load(object sender, EventArgs e)
        {
            LoadEvent(sender, e);
            OnUserCahngeEvent(sender, e);
            
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCriminalEvent(sender, e);           
        }
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ci = new CriminalInfo((Criminal)List.CurrentRow.DataBoundItem);
            if (ci.ShowDialog() == DialogResult.OK)
            {
                CBS.ResetBindings(false);                
            }

        }
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            var c = (DataGridView)listControl.SelectedTab.Controls[0];
            var i = c.CurrentRow.DataBoundItem;
            if(i is Criminal)
            {
                new CriminalInfo((Criminal)i).ShowDialog();                
            }
            if(i is CriminalGang)
            {
                new GangInfo((CriminalGang)i).ShowDialog();
            }
            CBS.ResetBindings(false);
            ABS.ResetBindings(false);
            GBS.ResetBindings(false);
        }

            

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveToArchiveEvent(sender, e);
        }
        private void moveToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveToListevent(sender, e);
        }
        private void ListMenu_KeyDown(object sender, KeyEventArgs e)
        {
            AutorizationEvent(sender, e);
            OnUserCahngeEvent(sender, e);
        }
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddGangEvent(sender, e);            
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteEvent(sender, e);            
        }
        private void changeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var changeresult = new GangInfo((CriminalGang)GangList.CurrentRow.DataBoundItem).ShowDialog();
            if (changeresult == DialogResult.OK)
            {
                GangList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                GBS.ResetBindings(false);                
            }
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                SearchEvent(sender, e);
            }
            else
            {
                ResetEvent(sender, e);
            }
        }
        private void nationalityBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace((string)nationalityBox.SelectedItem))
            {
                NationalityChangedEvent(sender, e);
            }
            else
            {
                ResetEvent(sender, e);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.Role = UserRole.User;
            OnUserCahngeEvent(sender, e);
        }
        private void ListMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEvent(sender, e);
        }


        #endregion

        private void criminalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
