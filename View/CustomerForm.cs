using System;
using System.Windows.Forms;

namespace Contactmanager
{
    public partial class CustomerForm : Form
    {
        private Controller Controller { get; }
        private bool IsUpdate { get; }
        public CustomerForm(Controller controller)
        {
            InitializeComponent();
            Controller = controller;
            IsUpdate = false;
        }

        public CustomerForm(Controller controller, Customer customer) : this(controller)
        {
            InitializeCustomer(customer);
            IsUpdate = true;
        }

        private void InitializeCustomer(Customer customer)
        {
            TxtCompany.Text = customer.Company;
            TxtStreet.Text = customer.Address.Street;
            TxtHouseNr.Text = customer.Address.HouseNumber.ToString();
            TxtPlz.Text = customer.Address.PLZ.ToString();
            TxtResidence.Text = customer.Address.Village;
            TxtTitle.Text = customer.Title;
            TxtFirstname.Text = customer.Firstname;
            TxtLastname.Text = customer.Lastname;
            TxtPrivateNr.Text = customer.PrivateNr;
            TxtMobilNr.Text = customer.MobileNr;
            TxtMail.Text = customer.Mail;
        }

        private Customer getCustomer()
        {
            Customer customer = new Customer(TxtTitle.Text, TxtFirstname.Text, TxtLastname.Text, false, false, new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text), TxtPrivateNr.Text, TxtMail.Text, TxtCompany.Text, CmbCustomerType.Text);
            return customer;
        }

        private void CmdSaveCustomer_Click(object sender, EventArgs e)
        {
            bool success = IsUpdate ? Controller.UpdatePerson(getCustomer()) : Controller.SaveNewPerson(getCustomer());
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
    }
}
