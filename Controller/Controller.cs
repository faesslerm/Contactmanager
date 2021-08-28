using System;

namespace Contactmanager
{
    public class Controller
    {
        private Model model;
        private Person personToBeUpdated;

        public Controller()
        {
            model = new Model();
            personToBeUpdated = null;
        }

        public bool SaveNewPerson(Person p)
        {
            if (model.Find(p))
                return false;
            else
                model.Add(p);
            return true;
        }

        public Person[] GetAllPeople()
        {
            return model.GetAll();
        }

        public Person GetPerson(Person p)
        {
            return model.Get(p);
        }

        public bool DeletePerson(Person p)
        {
            if (p != null)
            {
                return model.Delete(p);
            }
            return false;
        }

        public bool DisablePerson(Person p)
        {
            if (p != null)
            {
                return model.Disable(p);
            }
            return false;
        }

        public bool EnablePerson(Person p)
        {
            if (p != null)
            {
                return model.Enable(p);
            }
            return false;
        }

        public void PersonToBeUpdated(Person p)
        {
            personToBeUpdated = p;
        }

        public bool UpdatePerson(Person p)
        {
            return model.Update(personToBeUpdated, p);
        }


        //Eingabe wird überprüft, ob es ausschliesslich Buchstaben beinhaltet.

        public bool CheckIsItLetter(string inputText)
        {
            foreach (char c in inputText)
            {
                if (!Char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        // Eingabe wird überprüft, ob es ausschlisslich Zahlen beinhaltet.

        public bool CheckIsItNumeric(string inputZahl)
        {
            foreach (char c in inputZahl)
            {
                if (!Char.IsLetter(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        // Eingabe wird überprüft, ob die E-Mail Adresse grundsätzlich eine gültige Schreibweise erfüllt.

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
