using System;
using System.Windows.Forms;

namespace Contactmanager
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller controller = new Controller();
            LoginForm loginForm = new LoginForm(controller);
            Application.Run(loginForm);
            if (loginForm.IsLoggedIn)
            {
                Application.Run(new MainForm(controller));
            }
        }
    }
}
