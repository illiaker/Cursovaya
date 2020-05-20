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
        //Constructor
        public Autorization(ListMenu lm)
        {
            InitializeComponent();
            ListMenu = lm;
            new AutorizationPresenter(this);

        }
        #region Events
        public event EventHandler LogInEvent = null;
        #endregion

        #region Properties
        public ListMenu ListMenu { get; set; }
        public string Login { get { return login.Text; } set { login.Text = value; } }
        public string Password { get { return password.Text; } set { password.Text = value; } }
        #endregion

        #region EvenHandlers
        private void Log_In_Click(object sender, EventArgs e)
        {
            LogInEvent(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}
