using System;
using System.Collections.Generic;

namespace Contactmanager
{
    [Serializable]


    public class Person
    {
        //Properties

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsMen { get; set; } // Geschlecht true = männlich, false = weiblich
        public DateTime Birthday { get; set; }
        public string Title { get; set; } //Titel
        public string MobileNr { get; set; }
        public string PrivateNr { get; set; }
        public string Mail { get; set; }
        public string AHV { get; set; } // string da es Punkte drin hat
        public string Nationality { get; set; }
        public Address Address { get; set; }
        public bool IsDisabled { get; set; }
        public List<History> Histories { get; }

        //Konstruktor:
        public Person(string firstname, string lastname, bool isMen, bool isDisabled, Address address)
        {
            Firstname = firstname;
            Lastname = lastname;
            IsMen = isMen;
            IsDisabled = isDisabled;
            Address = address;
            Histories = new List<History>();
        }

        // Methode zur Überprüfung auf Duplikate
        public bool Equals(Person other)
        {
            if (other == null)
                return false;
            if (Firstname.Equals(other.Firstname) &&
                Lastname.Equals(other.Lastname) &&
                IsMen == other.IsMen)
                return true;
            return false;
        }

        // Methode um Objekt auszugeben
        public override string ToString()
        {
            string peopleAsString = Firstname + ", " + Lastname + ", " + ", ";
            peopleAsString += IsMen == false ? "weiblich, " : "männlich, ";
            peopleAsString += IsDisabled == false ? "inaktiv" : "aktiv";
            return peopleAsString;
        }

        public string[] getGridRow()
        {
            return new string[] { Firstname, Lastname, Address.Street, Address.HouseNumber.ToString(), Address.PLZ.ToString(), Address.Village, Address.Country };
        }
    }
}
