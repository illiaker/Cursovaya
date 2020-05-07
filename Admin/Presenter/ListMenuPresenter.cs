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
            listView.DeleteEvent += ListView_DeleteEvent;
        }

        private void ListView_DeleteEvent(object sender, EventArgs e)
        {
            fileCabinet.Criminals.Remove((Criminal)listView.List.CurrentRow.DataBoundItem);
            Refresh();
        }

        private void ListView_LoadEvent(object sender, EventArgs e)
        {
            fileCabinet.Load();
            Refresh();
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
