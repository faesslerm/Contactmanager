using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactmanager
{
    class Customer: Person
    {
        public string Company { get; set; } // Firmenname
        public string CustomerAdress { get; set; } // Geschäftsadresse
        public string CustomerType { get; set; } // Kundentyp (A-E)
        public string Contact { get; set; } // Firmenkontakt
        public bool Status { get; set; } //Status (aktiv, passiv)


        public Customer(string salutation, string firstname, string lastname,
            DateTime birthday, int age, bool sex, string title, int mobilenr,
            int privatenr, string mail, int ahv, string residence, string nationality,
            string adress, int plz, string comment, string company, string customerAdress,
            string customerType, string contact, bool status):
            base(salutation, firstname, lastname,birthday, age, sex, title, mobilenr,
             privatenr, mail, ahv, residence, nationality,adress, plz, comment)
        {
            Company = company;
            CustomerAdress = customerAdress;
            CustomerType = customerType;
            Contact = contact;
            Status = status;
        }
    }
}
