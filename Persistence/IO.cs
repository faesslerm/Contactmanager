﻿using System;
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
            FileStream fs = new FileStream(@locationAndName, FileMode.Create, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();
            bool status = false;
            try
            {
                formatter.Serialize(fs, data);
                status = true;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
            }
            finally
            {
                fs.Close();
            }
            return status;
        }

        public static Person[] Load()
        {
            Person[] data = null;
            FileStream fs = new FileStream(@locationAndName, FileMode.Open, FileAccess.Read);
            try
            {
                IFormatter formatter = new BinaryFormatter();
                 data = (Person[])formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
            }
            finally
            {
                fs.Close();
            }
            return data;
        }
    }
}
