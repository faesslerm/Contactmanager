using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class LoginForm : Form
    {
        private string user = "Admin";
        private string password = "1234";
        public Controller Controller { get; }
        public bool IsLoggedIn { get { return loggedIn; } }
        private bool loggedIn = false;
        public LoginForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if (user.Equals(TxtUser.Text) && password.Equals(TxtPassword.Text))
            {
                MessageBox.Show("Login Erfolgreich", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Falscher Benutzer oder Passwort!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
