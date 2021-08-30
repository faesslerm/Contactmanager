using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class EmployeeForm : Form
    {
        public Controller Controller { get; }
        private bool IsUpdate { get; set; }
        private Person InitPerson { get; }

        public EmployeeForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            IsUpdate = false;
        }

        public EmployeeForm(Controller controller, Person person) : this(controller)
        {
            InitPerson = person;
            InitializePerson(InitPerson);
            IsUpdate = true;
        }

        private void InitializePerson(Person person)
        {
            CmbSalutation.Text = person.IsMen ? "Herr" : "Frau";
            TxtFirstname.Text = person.Firstname;
            TxtLastname.Text = person.Lastname;
        }

        private void InitializeEmployee(Employee employee)
        {
            TxtEmployeeNr.Text = Convert.ToString(employee.EmployeeNr);
        }

        private void CmdSaveEmployee_Click(object sender, EventArgs e)
        {
            Person person;
            bool isMen = CmbSalutation.Text.Equals("Herr");
            if (TxtDepartment.Text.Length > 0)
            {
                person = new Employee(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                    TxtAhv.Text, TxtCompanyPhoneNr.Text, TxtDepartment.Text, DateTime.Parse(TxtEntry.Text), TxtLevelOfEmployment.Text, TxtFunction.Text, Convert.ToByte(CmbSquadLevel.Text));
            }
            else if (TxtApprenticeshipYears.Text.Length > 0)
            {
                person = new Trainee(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                    TxtAhv.Text, TxtCompanyPhoneNr.Text, TxtDepartment.Text, DateTime.Parse(TxtEntry.Text), TxtLevelOfEmployment.Text, TxtFunction.Text, Convert.ToByte(CmbSquadLevel.Text),
                    Convert.ToInt32(TxtApprenticeshipYears.Text));
            }
            else
            {
                person = new Person(TxtFirstname.Text, TxtLastname.Text, isMen, RadActiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text),
                    TxtResidence.Text, TxtCountry.Text));
            }
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
