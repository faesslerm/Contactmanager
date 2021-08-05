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
    }
}
