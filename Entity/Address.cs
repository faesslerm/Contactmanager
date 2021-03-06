using System;

namespace Contactmanager
{
    [Serializable]

    public class Address
    {
        //Properties
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PLZ { get; set; }
        public string Village { get; set; } //Ortschaft
        public string Country { get; set; } //Land

        //Konstruktor
        public Address(string street, int houseNumber, int plz, string village,
            string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            PLZ = plz;
            Village = village;
            Country = country;
        }

        public bool Equals(Address other)
        {
            if (other == null)
                return false;
            if (Street.Equals(other.Street) &&
                HouseNumber == other.HouseNumber &&
                PLZ == other.PLZ &&
                Village.Equals(other.Village) &&
                Country.Equals(other.Country))
                return true;
            return false;
        }
    }
}
