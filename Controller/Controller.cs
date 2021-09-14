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

        /**************************************************
         * Sofern die Person noch nicht vorhanden ist,
         * übergibt der Controller die Personendaten dem
         * Model, um sie abzuspeichern.
         * ***********************************************/
        public bool SaveNewPerson(Person p)
        {
            if (model.Find(p))
                return false;
            else
                model.Add(p);
            return true;
        }

        /**************************************************
         * Der Contorller fordert beim Model alle 
         * Personendaten an.
         * ***********************************************/
        public Person[] GetAllPeople()
        {
            return model.GetAll();
        }

        /**************************************************
         * Sucht eine gewisse Person und gibt diese, falls
         * im Model vorhanden, zurück.
         * ***********************************************/
        public Person GetPerson(Person p)
        {
            return model.Get(p);
        }

        /**************************************************
         * Löscht eine Person, falls die nichts beinhaltet
         * ***********************************************/
        public bool DeletePerson(Person p)
        {
            if (p != null)
            {
                return model.Delete(p);
            }
            return false;
        }

        /**************************************************
         * Deaktiviert eine Person, sofern sie nicht
         * gleich null ist.
         * ***********************************************/
        public bool DisablePerson(Person p)
        {
            if (p != null)
            {
                return model.Disable(p);
            }
            return false;
        }

        /**************************************************
         * Aktiviert eine Person, sofern sie nicht gleich
         * null ist.
         * ***********************************************/
        public bool EnablePerson(Person p)
        {
            if (p != null)
            {
                return model.Enable(p);
            }
            return false;
        }

        /**************************************************
         * Übergibt die alten Personendaten, um sie zu
         * einem späteren Zeitpunkt zu erneuern.
         * ***********************************************/
        public void PersonToBeUpdated(Person p)
        {
            personToBeUpdated = p;
        }

        /**************************************************
         * Übergibt dem Model die aktuellen Personen-
         * daten und überschreibt die alten Eigenschaften.
         * ***********************************************/
        public bool UpdatePerson(Person p)
        {
            return model.Update(personToBeUpdated, p);
        }


        /**************************************************
         * Eingabe wird überprüft, ob es ausschliesslich 
         * Buchstaben beinhaltet.
         * ***********************************************/
        public bool CheckIsItLetter(string inputText)
        {
            foreach (char c in inputText)
            {
                if (Char.IsDigit(c) || c == '.')
                {
                    return false;
                }
            }
            return true;
        }

        /**************************************************
         * Eingabe wird überprüft, ob es ausschlisslich 
         * Zahlen beinhaltet.
         * ***********************************************/
        public bool CheckIsItNumeric(string inputZahl)
        {
            foreach (char c in inputZahl)
            {
                if (Char.IsLetter(c) || c == '.')
                {
                    return false;
                }
            }
            return true;
        }

        /***************************************************
         * Eingabe wird überprüft, ob die E-Mail Adresse 
         * grundsätzlich eine gültige Schreibweise erfüllt.
         * ************************************************/
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
