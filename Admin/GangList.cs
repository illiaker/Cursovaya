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
    public partial class GangList : Form
    {
        public GangList()
        {
            InitializeComponent();
            fileCabinet = FileCabinet.GetInstance();
        }
        FileCabinet fileCabinet;
        public CriminalGang Gang { get;private set; }

        private void GangList_Load(object sender, EventArgs e)
        {
            criminalGangBindingSource.DataSource = fileCabinet.CriminalGangs;
            criminalGangBindingSource.ResetBindings(false);
        }

        private void GangList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gangGridView.CurrentRow != null)
            {
                var g = gangGridView.CurrentRow.DataBoundItem as CriminalGang;
                if (DialogResult == DialogResult.OK)
                {
                    Gang = g;
                }
            }
        }
    }
}
