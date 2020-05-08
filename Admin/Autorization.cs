using AdminView.Presenter;
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
    public partial class Autorization : Form
    {
        public Autorization(ListMenu lm)
        {
            InitializeComponent();
            ListMenu = lm;
            new AutorizationPresenter(this);

        }
        public ListMenu ListMenu { get; set; }
        public string Login { get { return login.Text; } set { login.Text = value; } }
        public string Password { get { return password.Text; } set { password.Text = value; } }

        public event EventHandler LogInEvent = null;
        private void Log_In_Click(object sender, EventArgs e)
        {
            LogInEvent(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
