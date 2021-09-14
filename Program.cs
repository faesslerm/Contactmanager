using System;
using System.Windows.Forms;

namespace Contactmanager
{
    static class Program
    {
        [STAThread]
        /**********************************************************
         * Hier wird definiert, dass beim Starten der Applikation,
         * zuerst das LoginForm geöffnet wird. Wenn diese ge-
         * schlossen wird (Login erfolgreich), wird die MainForm
         * gestartet.
         * *******************************************************/
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
