using System;

namespace Contactmanager
{
    [Serializable]


    public class Person
    {
        public string Salutation { get; set; } // Anrede
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; } // Alter Hinweis: Im Auftrag nicht enthalten
        public bool Sex { get; set; } // Geschlecht
        public string Title { get; set; } //Titel
        public int MobileNr { get; set; }
        public int PrivateNr { get; set; }
        public string Mail { get; set; }
        public int AHV { get; set; }
        public string Residence { get; set; } // Wohnort
        public string Nationality { get; set; } // Nationalität
        public string Adress { get; set; }
        public int PLZ { get; set; }
        public string Comment { get; set; }
        public bool IsDisabled { get; set; }

        //alter Konstruktor:
        public Person(string firstname, string lastname, int age, bool sex)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Sex = sex;
            Comment = "";
            IsDisabled = false;
        }

        //neuer Konstruktor:
        public Person(string salutation, string firstname, string lastname,
            DateTime birthday, int age, bool sex, string title, int mobilenr,
            int privatenr, string mail, int ahv, string residence, string nationality,
            string adress, int plz, string comment)
        {
            Salutation = salutation;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Age = age;
            Sex = sex;
            Title = title;
            MobileNr = mobilenr;
            PrivateNr = privatenr;
            Mail = mail;
            AHV = ahv;
            Residence = residence;
            Nationality = nationality;
            Adress = adress;
            PLZ = plz;
            Comment = "";
            IsDisabled = false;
        }

        public bool Equals(Person other)
        {
            if (other == null)
                return false;
            if (Firstname.Equals(other.Firstname) &&
                Lastname.Equals(other.Lastname) &&
                Age == other.Age &&
                Sex == other.Sex)
                return true;
            return false;
        }

        public override string ToString()
        {
            string peopleAsString = Firstname + ", " + Lastname + ", " + Age + ", ";
            peopleAsString += Sex == false ? "männlich," : "weiblich,";
            peopleAsString += Comment.Length > 0 ? Comment : " ";
            return peopleAsString;

        }
    }
}
