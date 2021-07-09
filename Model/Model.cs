using Contactmanager.Persistence;

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
                    temp[c] = people[c];
                }
                return temp;
            }
            return null;
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
            people[pos] = update;
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
