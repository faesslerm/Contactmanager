using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Contactmanager.Persistence
{
    public static class IO
    {
        private const string locationAndName = "./people.data";
        public static bool Save(Person[] data)
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream(@locationAndName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, data);
                stream.Close();
                return true;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static Person[] Load()
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream(@locationAndName, FileMode.Open, FileAccess.Read);
                Person[] data = (Person[])formatter.Deserialize(stream);
                stream.Close();
                return data;
            }
            catch (IOException)
            {
                return null;
            }
        }
    }
}
