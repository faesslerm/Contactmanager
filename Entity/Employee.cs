using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactmanager
{
    class Employee: Person
    {
        public int CompanyPhoneNr { get; set; } //Telefonnummer
        public int CompanyFaxNr { get; set; } //Faxnummer
        public int EmployeeNr { get; set; } //Mitarbeiternummer
        public string Department { get; set; } // Abteilung
        public DateTime Entry { get; set; } // Eintritt
        public DateTime Leaving { get; set; } // Austritt
        public double LevelOfEmployment { get; set; } //Beschäftigungsgrad
        public string Function { get; set; } //Tätigkeitsbezeichnung
        public byte SquadLevel { get; set; } //Kaderstufe (0-5)

        public Employee(string salutation, string firstname, string lastname,
            DateTime birthday, int age, bool sex, string title, int mobilenr,
            int privatenr, string mail, int ahv, string residence, string nationality,
            string adress, int plz, string comment, int companyPhoneNr, int companyFaxNr,
            int employeeNr, string department, DateTime entry, DateTime leaving, double levelOfEmployment,
            string function, byte squadLevel) :
            base(salutation, firstname, lastname, birthday, age, sex, title, mobilenr,
             privatenr, mail, ahv, residence, nationality, adress, plz, comment)
        {
            CompanyPhoneNr = companyPhoneNr;
            CompanyFaxNr = companyFaxNr;
            EmployeeNr = employeeNr;
            Department = department;
            Entry = entry;
            Leaving = leaving;
            LevelOfEmployment = levelOfEmployment;
            Function = function;
            SquadLevel = squadLevel;
        }

    }
}
