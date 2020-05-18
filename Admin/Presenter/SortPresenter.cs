using Cursovaya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Presenter
{
    class SortPresenter
    {
        ISort form;
        FileCabinet fileCabinet;
        public SortPresenter(ISort form)
        {
            this.form = form;
            fileCabinet = FileCabinet.GetInstance();
            form.NationalityChangedEvent += Form_NationalityChangedEvent;
            form.SearchEvent += Form_SearchEvent;
            
        }

        
        private void Form_SearchEvent(object sender, EventArgs e)
        {
            
            TextBox s = (TextBox)sender;
            
            form.CBS.DataSource = fileCabinet.Search(s.Text);
            form.CBS.ResetBindings(false);
        }

        private void Form_NationalityChangedEvent(object sender, EventArgs e)
        {
            ComboBox b = sender as ComboBox;
            form.CBS.DataSource = fileCabinet.Nationality((string)b.SelectedItem);
            form.CBS.ResetBindings(false);
        }
    }
}
