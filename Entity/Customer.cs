using System;
using System.Collections.Generic;

namespace Contactmanager
{
    [Serializable]
    public class Customer : Person
    {
        //Properties
        public string Company { get; set; } // Firmenname
        public string CustomerType { get; set; } // Kundentyp (A-E)
        public string Contact { get; set; } // Firmenkontakt
        public bool Status { get; set; } //Status (aktiv, passiv)
        public Notes Notes { get; set; }
        public List<History> Histories { get; }

        //Konstruktor
        public Customer(string title, string firstname, string lastname, bool isMen, bool isDisabled, Address address, string privateNr, string mail, string company,
            string customerType) :
            base(firstname, lastname, isMen, isDisabled, address)
        {
            //Person
            Title = title;
            PrivateNr = privateNr;
            Mail = mail;

            //Customer
            Company = company;
            CustomerType = customerType;

            Histories = new List<History>();
        }
    }
}
