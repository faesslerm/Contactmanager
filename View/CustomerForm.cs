using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class CustomerForm : Form
    {
        private Controller Controller { get; }
        private bool IsUpdate { get; }
        private Customer InitCustomer { get; }
        public CustomerForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            IsUpdate = false;
        }

        /*************************************************************************
         * Controller und Customer wird übergeben, damit die Personendaten in der
         * Form ausgefüllt werden.
         * **********************************************************************/
        public CustomerForm(Controller controller, Customer customer) : this(controller)
        {
            InitCustomer = customer;
            InitializeCustomer(InitCustomer);
            IsUpdate = true;
        }

        /*************************************************************************
         * Die Properties werden dem entsprechenden Textfeld zugewiesen.
         * **********************************************************************/
        private void InitializeCustomer(Customer customer)
        {
            TxtCompany.Text = customer.Company;
            TxtStreet.Text = customer.Address.Street;
            TxtHouseNr.Text = customer.Address.HouseNumber.ToString();
            TxtPlz.Text = customer.Address.PLZ.ToString();
            TxtResidence.Text = customer.Address.Village;
            TxtCountry.Text = customer.Address.Country;
            CmbCustomerType.SelectedItem = customer.CustomerType;
            RadActiv.Checked = !customer.IsDisabled;
            RadPassiv.Checked = customer.IsDisabled;
            TxtTitle.Text = customer.Title;
            TxtFirstname.Text = customer.Firstname;
            TxtLastname.Text = customer.Lastname;
            TxtPrivateNr.Text = customer.PrivateNr;
            TxtMobilNr.Text = customer.MobileNr;
            TxtMail.Text = customer.Mail;
            TxtNotes.Text = customer.Notes.Comment;
        }

        /*************************************************************************
         * Es wird ein neues Customer-Objekt mit allen Textfeldern erstellt.
         * **********************************************************************/
        private Customer GetCustomer()
        {
            Customer customer = new Customer(TxtTitle.Text, TxtFirstname.Text, TxtLastname.Text, false, false,
                new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text), string.Empty,
                TxtPrivateNr.Text, TxtMail.Text, TxtCompany.Text, CmbCustomerType.SelectedItem as string);
            customer.MobileNr = TxtMobilNr.Text;
            customer.IsDisabled = RadPassiv.Checked;
            customer.Notes = new Notes(DateTime.Now, TxtNotes.Text);
            return customer;
        }

        /*************************************************************************
         * Die einzelnen Textfelder werden überprüft und wenn alle valide sind,
         * wird true zurückgegeben.
         *************************************************************************/
        private bool checkFields()
        {
            return Validation.CheckText(TxtCompany)
                    && Validation.CheckText(TxtStreet)
                    && Validation.CheckNumber(TxtHouseNr)
                    && Validation.CheckNumber(TxtPlz)
                    && Validation.CheckText(TxtResidence)
                    && Validation.CheckText(TxtCountry)
                    && Validation.CheckText(TxtTitle)
                    && Validation.CheckText(TxtFirstname)
                    && Validation.CheckText(TxtLastname)
                    && Validation.CheckNumber(TxtPrivateNr)
                    && Validation.CheckNumber(TxtMobilNr)
                    && Validation.CheckMail(TxtMail);
        }

        /*************************************************************************
         * Die einzelnen Textfelder werden überprüft und anschliessen abge-
         * speichert. Falls der Kunde schon existiert, erscheint eine Fehler-
         * meldung.
         * **********************************************************************/
        private void CmdSaveCustomer_Click(object sender, EventArgs e)
        {
            if (!checkFields())
            {
                return;
            }

            Customer customer = GetCustomer();
            bool success = IsUpdate ? Controller.UpdatePerson(customer) : Controller.SaveNewPerson(customer);
            if (success)
            {
                MessageBox.Show("Kunde wurde erfolgreich gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kunde existiert bereits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*************************************************************************
         * Wenn auf das History-Icon geklickt wird, öffnet sich die HistoryForm
         * mit den entsprechenden Notizen.
         * **********************************************************************/
        private void CmdHistory_Click(object sender, EventArgs e)
        {
            if (InitCustomer != null)
            {
                new HistoryForm(InitCustomer.NotesHistory).ShowDialog();
            }
        }
    }
}
