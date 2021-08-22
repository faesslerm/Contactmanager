using System;

namespace Contactmanager
{
    public class Employee : Person
    {

        //Properties
        public string CompanyPhoneNr { get; set; } //Telefonnummer
        public string CompanyFaxNr { get; set; } //Faxnummer
        public int EmployeeNr { get; set; } //Mitarbeiternummer --> Autoincrement Variable einsetzen?
        public string Department { get; set; } // Abteilung
        public DateTime Entry { get; set; } // Eintritt
        public DateTime Leaving { get; set; } // Austritt
        public string LevelOfEmployment { get; set; } //Beschäftigungsgrad
        public string Function { get; set; } //Tätigkeitsbezeichnung
        public byte SquadLevel { get; set; } //Kaderstufe (0-5)

        private static int number = 0; // Autoincrement für Mitarbeiternummer


        // Konstruktor:
        public Employee(string firstname, string lastname, bool isMen, bool isDisabled, Address address, string ahv, string companyPhoneNr, string department,
            DateTime entry, string levelOfEmployment, string function, byte squadLevel) :
            base(firstname, lastname, isMen, isDisabled, address)
        {
            CompanyPhoneNr = companyPhoneNr;
            EmployeeNr = number++;
            Department = department;
            Entry = entry;
            LevelOfEmployment = levelOfEmployment;
            Function = function;
            SquadLevel = squadLevel;
        }

        public int getNumber()
        {
            return number;
        }
    }
}
