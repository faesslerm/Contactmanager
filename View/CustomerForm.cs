﻿using System;
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
            TxtCountry.Text = customer.Address.Country;
            CmbCustomerType.Text = customer.CustomerType;
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

        private Customer getCustomer()
        {
            Customer customer = new Customer(TxtTitle.Text, TxtFirstname.Text, TxtLastname.Text, false, false,
                new Address(TxtStreet.Text, Convert.ToInt32(TxtHouseNr.Text), Convert.ToInt32(TxtPlz.Text), TxtResidence.Text, TxtCountry.Text),
                TxtPrivateNr.Text, TxtMail.Text, TxtCompany.Text, CmbCustomerType.Text);
            customer.IsDisabled = RadPassiv.Checked;
            return customer;
        }

        private void CmdSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = getCustomer();
            if (TxtNotes.TextLength > 0)
            {
                customer.Notes = new Notes(DateTime.Now, TxtNotes.Text);
            }
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
    }
}
