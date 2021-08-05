using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class EmployeeForm : Form
    {
        public Controller Controller { get; }

        public EmployeeForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
        }

        private void CmdSaveEmployee_Click(object sender, EventArgs e)
        {
            bool isMen = TxtSalutation.Text.Equals("Herr");
            Person person = new Person(TxtFirstname.Text, TxtLastname.Text, isMen, false);
            bool success = Controller.SaveNewPerson(person);
            if (success)
            {
                MessageBox.Show("Person wurde erfolgreich gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Person existiert bereits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
