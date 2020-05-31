using Admin;
using AdminView.Presenter;
using Cursovaya.Model;
using FileCabinetLibrary.Model;
using System;
using System.Collections;
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
    public partial class ListMenu : Form
    {
        public ListMenu()
        {
            InitializeComponent();
            new ListMenuPresenter(this);            
            criminalsDataGridView.AutoGenerateColumns = false;
            gangGridView.AutoGenerateColumns = false;
            archiveDataGridView.AutoGenerateColumns = false;
            
            criteriaComboBox.SelectedIndex = 0;
            criteriaBox.SelectedIndex = 0;
        }

        FileCabinet fileCabinet;

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

        public event EventHandler SearchCriminalEvent;
        public event EventHandler SearchInArchiveEvent;
        public event EventHandler SearchGangEvent;
        public event EventHandler ResetEvent;

        private int lastSelectedColumnIdx = -1;


        #endregion

        #region Properties
        
        public ComboBox CriteriaArchiveBox { get => criteriaBox; set => criteriaBox = value; }
        public NumericUpDown FromAgeCriteriaBox { get => fromAgeCriteriaBox; set => fromAgeCriteriaBox = value; }
        public NumericUpDown ToAgeCriteriaBox { get => toAgeCriteriaBox; set => toAgeCriteriaBox = value; }
        public TabControl ListControl { get => listControl; set => listControl = value; }
        public ComboBox CriteriaBox { get => criteriaComboBox; set => criteriaComboBox = value; }
        public MenuStrip MenuStrip { get => adminMenuStrip; set => adminMenuStrip = value; }
        public DataGridView CriminalList { get { return criminalsDataGridView; } set { criminalsDataGridView = value; } }
        public DataGridView GangList { get => gangGridView; set => gangGridView = value; }
        public DataGridView ArchiveList { get { return archiveDataGridView; } set { archiveDataGridView = value; } }
        public BindingSource ABS { get => archiveBindingSource ; set => archiveBindingSource = value; }
        public BindingSource GBS { get => criminalGangBindingSource; set => criminalGangBindingSource = value; }
        public BindingSource CBS { get => criminalBindingSource; set => criminalBindingSource = value; }
        public IEnumerable tmpList { get; set; }
        #endregion

        #region EventHandlers
        private void ListMenu_Load(object sender, EventArgs e)
        {
            LoadEvent(sender, e);
            fileCabinet = FileCabinet.GetInstance();
            ToAgeCriteriaBox.Value = 100;
            toCriteriaArchiveBox.Value = 100;
            DisableButtons(listControl);
            OnUserCahngeEvent(sender, e);
            

        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCriminalEvent(sender, e);           
        }
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CriminalList.CurrentRow != null)
            {
                var ci = new CriminalInfo((Criminal)CriminalList.CurrentRow.DataBoundItem);
                if (ci.ShowDialog() == DialogResult.OK)
                {
                    CBS.ResetBindings(false);
                }
            }

        }
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            ShowResult();
        }

            

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            ResetEvent(sender, e);
            lastSelectedColumnIdx = -1;
            nationalityArchiveBox.SelectedIndex = 0;
            nationalitycriminalBox.SelectedIndex = 0;
            genderBox.SelectedIndex = 0;
            genderBox2.SelectedIndex = 0;
            DisableButtons((TabControl)sender);


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
            if (GangList.CurrentRow != null)
            {
                var changeresult = new GangInfo((CriminalGang)GangList.CurrentRow.DataBoundItem).ShowDialog();
                if (changeresult == DialogResult.OK)
                {
                    GangList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    GBS.ResetBindings(false);
                }
            }
        }
        private void searchcriminalBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchcriminalBox.Text))
            {
                SearchCriminalEvent(sender, e);
            }
            else
            {
                CBS.DataSource = tmpList == null ? fileCabinet.Criminals : tmpList;
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


        private void criminalsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
            ShowResult();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetEvent(sender, e);
            lastSelectedColumnIdx = -1;
            nationalityArchiveBox.SelectedIndex = 0;
            nationalitycriminalBox.SelectedIndex = 0;
            genderBox.SelectedIndex = 0;
            genderBox2.SelectedIndex = 0;
        }

        private void filterCriminalsOutButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nationalitycriminalBox.Text) && !String.IsNullOrWhiteSpace(genderBox.Text))
            {
                var list = fileCabinet.Criminals.Where(o => o.Nationality == nationalitycriminalBox.Text
                                                        && o.Age <= toAgeCriteriaBox.Value
                                                        && o.Age >= fromAgeCriteriaBox.Value
                                                        && o.Gender == genderBox.Text).ToList();
                tmpList = list;
            }
            else if(!string.IsNullOrWhiteSpace(nationalitycriminalBox.Text))
            {
                var list = fileCabinet.Criminals.Where(o => o.Nationality == nationalitycriminalBox.Text
                                                        && o.Age <= toAgeCriteriaBox.Value
                                                        && o.Age >= fromAgeCriteriaBox.Value).ToList();
                tmpList = list;
            }
            else if(!String.IsNullOrWhiteSpace(genderBox.Text))
            {
                var list = fileCabinet.Criminals.Where(o => o.Age <= toAgeCriteriaBox.Value
                                                        && o.Age >= fromAgeCriteriaBox.Value
                                                        && o.Gender == genderBox.Text).ToList();
                tmpList = list;
                
            }
            else
            {
                var list = fileCabinet.Criminals.Where(o => o.Age <= toAgeCriteriaBox.Value
                                                       && o.Age >= fromAgeCriteriaBox.Value).ToList();
                tmpList = list;
            }

            CBS.DataSource = tmpList == null ? fileCabinet.Criminals: tmpList;
            CBS.ResetBindings(false);

        }
        private void clearButton2_Click(object sender, EventArgs e)
        {
            ResetEvent(sender, e);
            fromCriteriaArchiveBox.Value = 0;
            toCriteriaArchiveBox.Value = 100;
        }
        
        private void ShowResult()
        {
            foreach (Control j in listControl.SelectedTab.Controls)
            {
                if (j is DataGridView c)
                {
                    if (c.CurrentRow != null)
                    {
                        var i = c.CurrentRow.DataBoundItem;
                        if (i is Criminal)
                        {
                            new CriminalInfo((Criminal)i).ShowDialog();
                        }
                        if (i is CriminalGang)
                        {
                            new GangInfo((CriminalGang)i).ShowDialog();
                        }
                        CBS.ResetBindings(false);
                        ABS.ResetBindings(false);
                        GBS.ResetBindings(false);
                        break;
                    }
                }
            }
        }

        private void searchBox2_TextChanged(object sender, EventArgs e)
        {
            SearchInArchiveEvent(sender, e);
        }
        
        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nationalityArchiveBox.Text) && !string.IsNullOrWhiteSpace(genderBox2.Text))
            {
                var list = fileCabinet.Archive.Where(o => o.Nationality == nationalityArchiveBox.Text
                                                        && o.Age <= toCriteriaArchiveBox.Value
                                                        && o.Age >= fromCriteriaArchiveBox.Value
                                                        && o.Gender == genderBox2.Text).ToList();
                tmpList = list;
            }
            else if (!string.IsNullOrWhiteSpace(nationalityArchiveBox.Text))
            {
                var list = fileCabinet.Archive.Where(o => o.Nationality == nationalityArchiveBox.Text
                                                        && o.Age <= toCriteriaArchiveBox.Value
                                                        && o.Age >= fromCriteriaArchiveBox.Value).ToList();
                tmpList = list;
                
            }
            else if(!string.IsNullOrWhiteSpace(genderBox2.Text))
            {
                var list = fileCabinet.Archive.Where(o => o.Age <= toCriteriaArchiveBox.Value
                                                        && o.Age >= fromCriteriaArchiveBox.Value
                                                        && o.Gender == genderBox2.Text).ToList();
                tmpList = list;
            }
            else 
            {
                var list = fileCabinet.Archive.Where(o => o.Age <= toCriteriaArchiveBox.Value
                                                        && o.Age >= fromCriteriaArchiveBox.Value).ToList();
                tmpList = list;
            }

            ABS.DataSource = tmpList == null? fileCabinet.Archive: tmpList;
            ABS.ResetBindings(false);
        }





        #endregion

        private void criminalsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Criminal> l = new List<Criminal>();
            if (tmpList != null)
            {
                l = tmpList as List<Criminal>;
            }
            else
            {
                l = fileCabinet.Criminals;
            }
            
            var s = sender as DataGridView;
            s.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Programmatic;
            
            var dataPropName = s.Columns[e.ColumnIndex].DataPropertyName;

            if (e.ColumnIndex != lastSelectedColumnIdx)
            {
                l = OrderBy(dataPropName, l);
                if (l != null)
                {
                    tmpList = l;
                    lastSelectedColumnIdx = e.ColumnIndex;
                }
            }
            else
            {
                l = OrderByDecsending(dataPropName, l);
                if (l != null)
                {
                    tmpList = l;
                    lastSelectedColumnIdx = -1;
                }
            }
            if(tmpList != null)
                CBS.DataSource = tmpList;
            CBS.ResetBindings(false);

        }

        private List<Criminal> OrderBy(string dataPropName, List<Criminal> l)
        {
            switch (dataPropName)
            {
                case "Name":
                    var nameList = l.OrderBy(o => o.Name).ToList();
                    return nameList as List<Criminal>;
                   
                case "Surname":
                    var surNameList = l.OrderBy(o => o.Surname).ToList();
                    return surNameList as List<Criminal>;
                   
                case "Alias":
                    var aliasList = l.OrderBy(o => o.Alias).ToList();
                    return aliasList as List<Criminal>;
                    
                case "Age":
                    var ageList = l.OrderBy(o => o.Age).ToList();
                    return ageList as List<Criminal>;
                    
                case "BirthDay":
                    var birthDayList = l.OrderBy(o => o.BirthDay).ToList();
                    return birthDayList as List<Criminal>;
                default:
                    return null;
            }

        }
        private List<Criminal> OrderByDecsending(string dataPropName, List<Criminal> l)
        {
            switch (dataPropName)
            {
                case "Name":
                    var nameList = l.OrderByDescending(o => o.Name).ToList();
                    return nameList as List<Criminal>;

                case "Surname":
                    var surNameList = l.OrderByDescending(o => o.Surname).ToList();
                    return surNameList as List<Criminal>;

                case "Alias":
                    var aliasList = l.OrderByDescending(o => o.Alias).ToList();
                    return aliasList as List<Criminal>;

                case "Age":
                    var ageList = l.OrderByDescending(o => o.Age).ToList();
                    return ageList as List<Criminal>;

                case "BirthDay":
                    var birthDayList = l.OrderByDescending(o => o.BirthDay).ToList();
                    return birthDayList as List<Criminal>;
                default:
                    return null;
            }

        }

        private void archiveDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Criminal> l = new List<Criminal>();
            if (tmpList != null)
            {
                l = tmpList as List<Criminal>;
            }
            else
            {
                l = fileCabinet.Archive;
            }

            var s = sender as DataGridView;
            s.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Programmatic;

            var dataPropName = s.Columns[e.ColumnIndex].DataPropertyName;

            if (e.ColumnIndex != lastSelectedColumnIdx)
            {
                l = OrderBy(dataPropName, l);
                if (l != null)
                {
                    tmpList = l;
                    lastSelectedColumnIdx = e.ColumnIndex;
                }
            }
            else
            {
                l = OrderByDecsending(dataPropName, l);
                if (l != null)
                {
                    tmpList = l;
                    lastSelectedColumnIdx = -1;
                }
            }
            if (tmpList != null)
                ABS.DataSource = tmpList;
            ABS.ResetBindings(false);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisableButtons(TabControl tabControl)
        {
            if(tabControl.SelectedIndex == 0)
            {
                changeToolStripMenuItem1.Enabled = false;
                moveToListToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem1.Enabled = true;
                changeToolStripMenuItem.Enabled = true;
                moveToArchive.Enabled = true;
            }
            else if(tabControl.SelectedIndex == 1)
            {
                changeToolStripMenuItem1.Enabled = true;
                moveToListToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
                changeToolStripMenuItem.Enabled = false;
                moveToArchive.Enabled = false;
            }
            else if(tabControl.SelectedIndex == 2)
            {
                changeToolStripMenuItem1.Enabled = false;
                moveToArchive.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
                changeToolStripMenuItem.Enabled = false;
                moveToListToolStripMenuItem.Enabled = true;
            }
        }

       

       
    }
}
