using System;

namespace Contactmanager
{
    public class Employee : Person
    {

        //Properties
        public int CompanyPhoneNr { get; set; } //Telefonnummer
        public int CompanyFaxNr { get; set; } //Faxnummer
        public int EmployeeNr { get; set; } //Mitarbeiternummer --> Autoincrement Variable einsetzen?
        public string Department { get; set; } // Abteilung
        public DateTime Entry { get; set; } // Eintritt
        public DateTime Leaving { get; set; } // Austritt
        public double LevelOfEmployment { get; set; } //Beschäftigungsgrad
        public string Function { get; set; } //Tätigkeitsbezeichnung
        public byte SquadLevel { get; set; } //Kaderstufe (0-5)

        private static int number = 0; // Autoincrement für Mitarbeiternummer


        // Konstruktor:
        public Employee(string firstname, string lastname, bool isMen, bool isDisabled, Address address, string ahv, int companyPhoneNr, int employeeNr, string department,
            DateTime entry, double levelOfEmployment, string function, byte squadLevel) :
            base(firstname, lastname, isMen, isDisabled, address)
        {
            CompanyPhoneNr = companyPhoneNr;
            EmployeeNr = employeeNr;
            Department = department;
            Entry = entry;
            LevelOfEmployment = levelOfEmployment;
            Function = function;
            SquadLevel = squadLevel;
            number++;
        }

        public int getNumber()
        {
            return number;
        }
    }
}
