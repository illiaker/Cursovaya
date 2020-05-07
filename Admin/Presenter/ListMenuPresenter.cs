using AdminView;
using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace AdminView.Presenter
{
    class ListMenuPresenter
    {
        ListMenu listView;
        FileCabinet fileCabinet;
        public ListMenuPresenter(ListMenu lView)
        {
            listView = lView;
            fileCabinet = new FileCabinet();
            listView.AddCriminalEvent += ListView_AddCriminalEvent;
            listView.LoadEvent += ListView_LoadEvent;
            listView.SaveEvent += ListView_SaveEvent;
            listView.MoveToArchiveEvent += ListView_MoveToArchiveEvent;
        }

        private void ListView_MoveToArchiveEvent(object sender, EventArgs e)

        {
            var i = MessageBox.Show("Are you sure you want to move this criminal to archive?","Conirm", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                fileCabinet.MoveToArchive((Criminal)listView.List.CurrentRow.DataBoundItem);
                fileCabinet.Save();
                Refresh();
            }
        }

        private void ListView_LoadEvent(object sender, EventArgs e)
        {
            try
            {
                fileCabinet.Load();
                Refresh();
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
            if(ci.ShowDialog() == DialogResult.OK)
            {
                fileCabinet.Criminals.Add(ci.Criminal);
                fileCabinet.Save();
                Refresh();
                

            }
        }

        private void Refresh()
        {
            listView.CBS.DataSource = null;
            listView.CBS.DataSource = fileCabinet.Criminals;
            listView.List.AutoGenerateColumns = false;
        }

       
    }
}
