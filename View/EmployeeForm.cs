using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class EmployeeForm : Form
    {
        public Controller Controller { get; }
        private bool IsUpdate { get; set; }

        public EmployeeForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            IsUpdate = false;
        }

        public EmployeeForm(Controller controller, Person person)
        {
            InitializeComponent();
            Controller = controller;
            InitializePerson(person);
            IsUpdate = true;
        }

        private void InitializePerson(Person person)
        {
            TxtSalutation.Text = person.IsMen ? "Herr" : "Frau";
            TxtFirstname.Text = person.Firstname;
            TxtLastname.Text = person.Lastname;
        }

        private void CmdSaveEmployee_Click(object sender, EventArgs e)
        {
            bool isMen = TxtSalutation.Text.Equals("Herr");
            Person person = new Person(TxtFirstname.Text, TxtLastname.Text, isMen, RadActiv.Checked);
            bool success = IsUpdate ? Controller.UpdatePerson(person) : Controller.SaveNewPerson(person);
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
