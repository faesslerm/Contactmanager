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
            if (person.Birthday.Year > 1)
            {
                TxtBirthday.Text = person.Birthday.ToShortDateString();
            }
            TxtTitle.Text = person.Title;
            TxtMobilNr.Text = person.MobileNr;
            TxtPrivateNr.Text = person.PrivateNr;
            TxtMail.Text = person.Mail;
            TxtAhv.Text = person.AHV;
            TxtNationality.Text = person.Nationality;
            TxtStreet.Text = person.Address.Street;
            TxtHouseNr.Text = person.Address.HouseNumber.ToString();
            TxtPlz.Text = person.Address.PLZ.ToString();
            TxtResidence.Text = person.Address.Village;
            TxtCountry.Text = person.Address.Country;
            RadActiv.Checked = !person.IsDisabled;
            RadPassiv.Checked = person.IsDisabled;
            if (person is Employee)
            {
                Employee employee = person as Employee;
                TxtCompanyPhoneNr.Text = employee.CompanyPhoneNr;
                TxtCompanyFaxNr.Text = employee.CompanyFaxNr;
                TxtEmployeeNr.Text = employee.EmployeeNr.ToString();
                TxtDepartment.Text = employee.Department;
                if (employee.Entry.Year > 1)
                {
                    TxtEntry.Text = employee.Entry.ToShortDateString();
                }
                if (employee.Leaving.Year > 1)
                {
                    TxtLeaving.Text = employee.Leaving.ToShortDateString();
                }
                TxtLevelOfEmployment.Text = employee.LevelOfEmployment;
                TxtFunction.Text = employee.Function;
                CmbSquadLevel.SelectedItem = employee.SquadLevel;
            }
        }

        private void InitializeEmployee(Employee employee)
        {
            TxtEmployeeNr.Text = Convert.ToString(employee.EmployeeNr);
        }

        public bool CheckNumber(TextBox text)
        {
            if (!Controller.CheckIsItNumeric(text.Text))
            {
                MessageBox.Show("Bitte verwende für " + (text.Name) + " nur Zahlen.", "Achtung!", MessageBoxButtons.OK);
                text.Text = String.Empty;
            }
            return true;
        }

        public bool CheckLabel(TextBox text)
        {
            if(!Controller.CheckIsItLetter(text.Text))
            {
                MessageBox.Show("Bitte verwende für " + (text.Name) + " nur Buchstaben.", "Achtung!", MessageBoxButtons.OK);
                text.Text = String.Empty; 
            }
            return true;
        }

        private void CmdSaveEmployee_Click(object sender, EventArgs e)
        { 
            CheckLabel(TxtFirstname);
            CheckLabel(TxtLastname);

            CheckNumber(TxtPlz);
            CheckNumber(TxtPrivateNr);
            CheckNumber(TxtMobilNr);
            CheckNumber(TxtHouseNr);
            

            Person person;
            bool isMen = CmbSalutation.Text.Equals("Herr");
            if (TxtDepartment.Text.Length > 0)
            {
                person = new Employee(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                    TxtAhv.Text, TxtCompanyPhoneNr.Text, TxtDepartment.Text, DateTime.Parse(TxtEntry.Text), TxtLevelOfEmployment.Text, TxtFunction.Text, Convert.ToByte(CmbSquadLevel.SelectedItem as string));
                person.Birthday = DateTime.Parse(TxtBirthday.Text);
            }
            else if (TxtApprenticeshipYears.Text.Length > 0)
            {
                person = new Trainee(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                    TxtAhv.Text, TxtCompanyPhoneNr.Text, TxtDepartment.Text, DateTime.Parse(TxtEntry.Text), TxtLevelOfEmployment.Text, TxtFunction.Text, Convert.ToByte(CmbSquadLevel.SelectedItem as string),
                    Convert.ToInt32(TxtApprenticeshipYears.Text));
            }
            else
            {
                person = new Person(TxtFirstname.Text, TxtLastname.Text, isMen, RadActiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text),
                    TxtResidence.Text, TxtCountry.Text));
                person.Birthday = DateTime.Parse(TxtBirthday.Text);
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
