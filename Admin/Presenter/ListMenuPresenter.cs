using AdminView;
using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;
using Admin;

namespace AdminView.Presenter
{
    class ListMenuPresenter
    {
        
        //Constructor
        public ListMenuPresenter(ListMenu lView)
        {
            listView = lView;
            fileCabinet = FileCabinet.GetInstance();
            listView.AddCriminalEvent += ListView_AddCriminalEvent;
            listView.LoadEvent += ListView_LoadEvent;
            listView.SaveEvent += ListView_SaveEvent;
            listView.MoveToArchiveEvent += ListView_MoveToArchiveEvent;
            listView.MoveToListevent += ListView_MoveToListevent;
            listView.AutorizationEvent += ListView_AutorizationEvent;
            listView.OnUserCahngeEvent += OnUserChange;
            listView.AddGangEvent += ListView_AddGangEvent;
            listView.DeleteEvent += ListView_DeleteEvent;
            listView.ResetEvent += ListView_ResetEvent;
            listView.TabChanged += ListView_TabChanged;
           
        }

        

        #region Field
        ListMenu listView;
        FileCabinet fileCabinet;
        #endregion

        #region EventHandler
        private void ListView_TabChanged(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            foreach(TabPage c in tc.TabPages)
            {
                if(c != tc.SelectedTab)
                {
                    c.SuspendLayout();    
                }                
            }
        }
        private void ListView_ResetEvent(object sender, EventArgs e)
        {
            listView.CBS.DataSource = fileCabinet.Criminals;
            listView.CBS.ResetBindings(false);
        }
        private void ListView_DeleteEvent(object sender, EventArgs e)
        {
            fileCabinet.Criminals.Remove((Criminal)listView.List.CurrentRow.DataBoundItem);
            listView.CBS.ResetBindings(false);

        }
        private void ListView_AddGangEvent(object sender, EventArgs e)
        {
            var gi = new GangInfo();
            if (gi.ShowDialog() == DialogResult.OK)
            {
                fileCabinet.CriminalGangs.Add(gi.Gang);
                listView.GBS.DataSource = fileCabinet.CriminalGangs;
                listView.GBS.ResetBindings(false);

            }
        }
        private void ListView_AutorizationEvent(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Insert && e.Control)
            {
                new Autorization(listView).ShowDialog();
            }
        }
        public void OnUserChange(object sender, EventArgs e)
        {
            if (User.Role == "user")
            {
                listView.MenuStrip.Hide();
            }
            else
            {
                listView.MenuStrip.Show();
            }
        }
        private void ListView_MoveToListevent(object sender, EventArgs e)
        {
            fileCabinet.MoveToList((Criminal)listView.ArchiveList.CurrentRow.DataBoundItem);
            listView.CBS.ResetBindings(false);
            listView.ABS.ResetBindings(false);
            fileCabinet.Save();
        }

        private void ListView_MoveToArchiveEvent(object sender, EventArgs e)
        {
            var i = MessageBox.Show("Are you sure you want to move this criminal to archive?", "Conirm", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                fileCabinet.MoveToArchive((Criminal)listView.List.CurrentRow.DataBoundItem);
                fileCabinet.Save();
                listView.CBS.ResetBindings(false);
                listView.ABS.ResetBindings(false);
            }
        }

        private void ListView_LoadEvent(object sender, EventArgs e)
        {
            try
            {
                fileCabinet.Load();
                listView.CBS.DataSource = fileCabinet.Criminals;
                listView.ABS.DataSource = fileCabinet.Archive;
                listView.GBS.DataSource = fileCabinet.CriminalGangs;
                listView.CBS.ResetBindings(false);
                listView.ABS.ResetBindings(false);
                listView.GBS.ResetBindings(false);
            }
            catch (Exception)
            {

            }



        }
        private void ListView_SaveEvent(object sender, EventArgs e)
        {
            fileCabinet.Save();

        }
        private void ListView_AddCriminalEvent(object sender, EventArgs e)
        {
            var ci = new CriminalInfo();
            if (ci.ShowDialog() == DialogResult.OK)
            {
                fileCabinet.Criminals.Add(ci.Criminal);
                fileCabinet.Save();
                listView.CBS.DataSource = fileCabinet.Criminals;
                listView.CBS.ResetBindings(false);


            }
        }
        #endregion

    }
}
