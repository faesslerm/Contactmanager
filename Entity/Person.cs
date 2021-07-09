using System;

namespace Contactmanager
{
    [Serializable]
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }

        public string Comment { get; set; }

        public Person(string firstname, string lastname,
            int age, bool sex)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Sex = sex;
            Comment = "";
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
