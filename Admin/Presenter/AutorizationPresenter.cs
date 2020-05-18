using System;
using System.Windows.Forms;
using Cursovaya.Model;



namespace AdminView.Presenter
{
    class AutorizationPresenter
    {
        Cursovaya.Model.Admin admin;
        Autorization auView;
       
        public AutorizationPresenter(Autorization au)
        {
            auView = au;
            
            admin = new Cursovaya.Model.Admin();
            auView.LogInEvent += AuView_LogInEvent;
        }

        private void AuView_LogInEvent(object sender, EventArgs e)
        {
            if(auView.Password == admin.Password && auView.Login == admin.Login)
            {
                auView.Close();
                User.Role = "admin";                
            }
            else
            {
                MessageBox.Show("Invalid login or password\nTry again");
                auView.Login = "";
                auView.Password = "";
            }
        }
    }
}
