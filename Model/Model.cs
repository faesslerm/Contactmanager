using Contactmanager.Persistence;
using System;

namespace Contactmanager
{
    public class Model
    {
        private Person[] people;
        private int counter;
        private const int dataLimit = 1000;

        public Model()
        {
            people = new Person[dataLimit];
            LoadData();
        }

        public bool Add(Person p)
        {
            if (people.Length > counter)
            {
                people[counter++] = p;
                SaveData();
                return true;
            }
            return false;
        }

        public Person Get(Person p)
        {
            if (counter > 0)
            {
                for (int c = 0; c < counter; c++)
                {
                    if (people[c].Equals(p))
                        return people[c];
                }
            }
            return null;
        }

        public Person[] GetAll()
        {
            if (counter > 0)
            {
                Person[] temp = new Person[counter];
                for (int c = 0; c < counter; c++)
                {
                    if (people[c].IsDisabled == false)
                    {
                        temp[c] = people[c];
                    }
                }
                return temp;
            }
            return new Person[0];
        }

        public string[] GetAllAsString()
        {
            if (counter > 0)
            {
                string[] temp = new string[counter];
                for (int c = 0; c < counter; c++)
                {
                    temp[c] = people[c].ToString();
                }
                return temp;
            }
            return null;
        }

        public bool Find(Person p)
        {
            if (Get(p) != null)
                return true;
            return false;
        }

        public int FindPosition(Person p)
        {
            for (int c = 0; c < counter; c++)
            {
                if (people[c].Equals(p))
                    return c;
            }
            return -1;
        }

        public bool Delete(Person p)
        {
            int pos = FindPosition(p);
            if (pos != -1)
            {
                for (int c = pos; c < counter; c++)
                {
                    people[c] = people[c + 1];
                }
                counter--;
                SaveData();
                return true;
            }
            return false;
        }

        public bool Update(Person old, Person update)
        {
            int pos = FindPosition(old);
            update.Histories.AddRange(old.Histories);
            UpdateHistory(old, update);
            UpdateNotesHistory(old, update);
            people[pos] = update;
            SaveData();
            return true;

        }

        private void UpdateHistory(Person old, Person update)
        {
            if (old.Firstname != null && !old.Firstname.Equals(update.Firstname))
            {
                update.Histories.Add(new History(DateTime.Now, "Vorname", old.Firstname));
            }
            if (old.Lastname != null && !old.Lastname.Equals(update.Lastname))
            {
                update.Histories.Add(new History(DateTime.Now, "Nachname", old.Lastname));
            }
            if (old.IsMen != update.IsMen)
            {
                update.Histories.Add(new History(DateTime.Now, "IsMen", old.IsMen.ToString()));
            }
            if (old.Birthday != null && !old.Birthday.Equals(update.Birthday))
            {
                update.Histories.Add(new History(DateTime.Now, "Geburtstag", old.Birthday.ToString()));
            }
            if (old.Title != null && !old.Title.Equals(update.Title))
            {
                update.Histories.Add(new History(DateTime.Now, "Titel", old.Title));
            }
            if (old.MobileNr != null && !old.MobileNr.Equals(update.MobileNr))
            {
                update.Histories.Add(new History(DateTime.Now, "Telefon Mobil", old.MobileNr));
            }
            if (old.PrivateNr != null && !old.PrivateNr.Equals(update.PrivateNr))
            {
                update.Histories.Add(new History(DateTime.Now, "Telefon Privat", old.PrivateNr));
            }
            if (old.Mail != null && !old.Mail.Equals(update.Mail))
            {
                update.Histories.Add(new History(DateTime.Now, "E-Mail", old.Mail));
            }
            if (old.AHV != null && !old.AHV.Equals(update.AHV))
            {
                update.Histories.Add(new History(DateTime.Now, "AHV Nummer", old.AHV));
            }
            if (old.Nationality != null && !old.Nationality.Equals(update.Nationality))
            {
                update.Histories.Add(new History(DateTime.Now, "Nationalität", old.Nationality));
            }
            if (old.Address.Street != null && !old.Address.Street.Equals(update.Address.Street))
            {
                update.Histories.Add(new History(DateTime.Now, "Strasse", old.Address.Street));
            }
            if (old.Address.HouseNumber != update.Address.HouseNumber)
            {
                update.Histories.Add(new History(DateTime.Now, "Hausnummer", old.Address.HouseNumber.ToString()));
            }
            if (old.Address.PLZ != update.Address.PLZ)
            {
                update.Histories.Add(new History(DateTime.Now, "Postleitzahl", old.Address.PLZ.ToString()));
            }
            if (old.Address.Village != null && !old.Address.Village.Equals(update.Address.Village))
            {
                update.Histories.Add(new History(DateTime.Now, "Ort", old.Address.Village));
            }
            if (old.Address.Country != null && !old.Address.Country.Equals(update.Address.Country))
            {
                update.Histories.Add(new History(DateTime.Now, "Land", old.Address.Country));
            }
            if (old.IsDisabled != update.IsDisabled)
            {
                update.Histories.Add(new History(DateTime.Now, "Aktiv / Deaktiv", old.IsDisabled.ToString()));
            }
        }

        private void UpdateNotesHistory(Person old, Person update)
        {
            if (old is Customer && update is Customer)
            {
                Customer oldCustomer = old as Customer;
                Customer updateCustomer = update as Customer;
                updateCustomer.NotesHistory.AddRange(oldCustomer.NotesHistory);
                if (!oldCustomer.Notes.Comment.Equals(updateCustomer.Notes.Comment)){
                    updateCustomer.NotesHistory.Add(new History(DateTime.Now, "Notizen", oldCustomer.Notes.Comment));
                }
            }
        }

        public bool Disable(Person p)
        {
            int pos = FindPosition(p);
            people[pos].IsDisabled = true;
            return true;
        }

        public bool Enable(Person p)
        {
            int pos = FindPosition(p);
            people[pos].IsDisabled = false;
            return true;
        }

        private void SaveData()
        {
            IO.Save(people);
        }

        private void LoadData()
        {
            Person[] p = IO.Load();
            if (p != null)
            {
                people = p;
                for (int c = 0; c < people.Length; c++)
                    counter = people[c] != null ? counter += 1 : counter;
            }

        }
    }
}
