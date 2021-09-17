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

        /*************************************************************************
         * Controller und Person wird übergeben, damit die Personendaten in der
         * Form ausgefüllt werden.
         * **********************************************************************/
        public EmployeeForm(Controller controller, Person person) : this(controller)
        {
            InitPerson = person;
            InitializePerson(InitPerson);
            IsUpdate = true;
        }

        /*************************************************************************
         * Die Properties werden dem entsprechenden Textfeld zugewiesen.
         * **********************************************************************/
        private void InitializePerson(Person person)
        {
            CmbSalutation.SelectedItem = person.IsMen ? "Herr" : "Frau";
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
                CmbSquadLevel.SelectedItem = Convert.ToString(employee.SquadLevel);
            }
            if (person is Trainee)
            {
                Trainee trainee = person as Trainee;
                TxtApprenticeshipYears.Text = trainee.NumberOfApprenticeship.ToString();
                TxtCurrentApprenticeshipYear.Text = trainee.GetApprenticeshipYear().ToString();
            }
        }

        /*************************************************************************
         * Die einzelnen Textfelder werden überprüft und wenn alle valide sind,
         * wird true zurückgegeben.
         *************************************************************************/
        private bool checkFields()
        {
            return Validation.CheckText(TxtFirstname)
                    && Validation.CheckText(TxtLastname)
                    && Validation.CheckText(TxtTitle)
                    && Validation.CheckText(TxtStreet)
                    && Validation.CheckNumber(TxtHouseNr)
                    && Validation.CheckNumber(TxtPlz)
                    && Validation.CheckText(TxtResidence)
                    && Validation.CheckText(TxtCountry)
                    && Validation.CheckNumber(TxtPrivateNr)
                    && Validation.CheckNumber(TxtMobilNr)
                    && Validation.CheckMail(TxtMail)
                    && Validation.CheckText(TxtNationality);
        }

        /*************************************************************************
         * Die einzelnen Textfelder werden überprüft und anschliessend abge-
         * speichert. Falls die Person schon existiert, erscheint eine Fehler-
         * meldung. Wenn das Feld "Abteilung" ausgefüllt wurde, wird ein
         * neuer Employee erstellt. Ist das Feld "Lehrjahre" ausgefüllt, wird ein
         * neuer Trainee erfasst. Falls keines der zuvor erwähnten Felder gegeben
         * wurde, wird eine Person erstellt.
         * **********************************************************************/
        private void CmdSaveEmployee_Click(object sender, EventArgs e)
        {
            if (!checkFields())
            {
                return;
            }
            Person person;
            bool isMen = "Herr".Equals(CmbSalutation.SelectedItem as string);
            if (TxtDepartment.Text.Length > 0)
            {
                Employee employee = new Employee(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                    TxtAhv.Text, TxtCompanyPhoneNr.Text, TxtDepartment.Text, DateTime.Parse(TxtEntry.Text), TxtLevelOfEmployment.Text, TxtFunction.Text, Convert.ToByte(CmbSquadLevel.SelectedItem as string));
                if (Validation.CheckDate(TxtBirthday))
                {
                    employee.Birthday = DateTime.Parse(TxtBirthday.Text);
                }
                employee.Mail = TxtMail.Text;
                employee.Title = TxtTitle.Text;
                employee.MobileNr = TxtMobilNr.Text;
                employee.PrivateNr = TxtPrivateNr.Text;
                employee.Nationality = TxtNationality.Text;
                employee.CompanyFaxNr = TxtCompanyFaxNr.Text;
                if (Validation.CheckDate(TxtLeaving))
                {
                    employee.Leaving = DateTime.Parse(TxtLeaving.Text);
                }
                person = employee;
            }
            else if (TxtApprenticeshipYears.Text.Length > 0)
            {
                person = new Trainee(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                    TxtAhv.Text, TxtCompanyPhoneNr.Text, TxtDepartment.Text, DateTime.Parse(TxtEntry.Text), TxtLevelOfEmployment.Text, TxtFunction.Text, Convert.ToByte(CmbSquadLevel.SelectedItem as string),
                    Convert.ToInt32(TxtApprenticeshipYears.Text));
                if (Validation.CheckDate(TxtBirthday))
                {
                    person.Birthday = DateTime.Parse(TxtBirthday.Text);
                }
                person.Mail = TxtMail.Text;
                person.Title = TxtTitle.Text;
                person.MobileNr = TxtMobilNr.Text;
                person.PrivateNr = TxtPrivateNr.Text;
                person.Nationality = TxtNationality.Text;
            }
            else
            {
                person = new Person(TxtFirstname.Text, TxtLastname.Text, isMen, RadPassiv.Checked,
                    new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text),
                    TxtResidence.Text, TxtCountry.Text), TxtAhv.Text);
                if (Validation.CheckDate(TxtBirthday))
                {
                    person.Birthday = DateTime.Parse(TxtBirthday.Text);
                }
                person.Mail = TxtMail.Text;
                person.Title = TxtTitle.Text;
                person.MobileNr = TxtMobilNr.Text;
                person.PrivateNr = TxtPrivateNr.Text;
                person.Nationality = TxtNationality.Text;
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
