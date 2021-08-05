namespace Contactmanager
{
    public class Customer : Person
    {
        //Properties
        public string Company { get; set; } // Firmenname
        public string CustomerType { get; set; } // Kundentyp (A-E)
        public string Contact { get; set; } // Firmenkontakt
        public bool Status { get; set; } //Status (aktiv, passiv)

        //Konstruktor
        public Customer(string firstname, string lastname, bool isMen, bool isDisabled, string company,
            string customerType, string contact, bool status) :
            base(firstname, lastname, isMen, isDisabled)
        {
            Company = company;
            CustomerType = customerType;
            Contact = contact;
            Status = status;
        }
    }
}
