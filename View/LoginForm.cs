using System;
using System.Windows.Forms;

namespace Contactmanager
{
    /*************************************************************************
     * Der Username und das Password ist hier definiert.
     * **********************************************************************/
    public partial class LoginForm : Form
    {
        private string user = "Admin";
        private string password = "1234";
        public Controller Controller { get; }
        public bool IsLoggedIn { get { return loggedIn; } }
        private bool loggedIn = false;

        /*************************************************************************
         * Der Controller wird aufgerufen.
         * **********************************************************************/
        public LoginForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        /*************************************************************************
         * Wird auf den Login Button geklickt, wird der Username und das Passwort
         * überprüft. Wenn diese stimmen, wird die Form geschlossen und die
         * MainForm wird ersichtlich, ist das Login falsch, wird eine MessageBox
         * angezeigt.
         * **********************************************************************/
        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if (user.Equals(TxtUser.Text) && password.Equals(TxtPassword.Text))
            {
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
