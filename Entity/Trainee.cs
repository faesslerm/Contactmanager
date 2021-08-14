using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactmanager
{
    class Trainee : Employee
    {

        //Properties
        public int NumberOfApprenticeship { get; } // Dauer der Ausbildung
        public int CurrentYearOfApprenticeship { get; set; } // Aktuelles Ausbildungsjahr


        //Konstruktor:
        public Trainee(string firstname, string lastname, bool isMen, bool isDiasabled, string ahv, int companyPhoneNr, int employeeNr, string department,
        DateTime entry, double levelOfEmployment, string function, byte squadLevel, int numberOfApprenticeship, int currentYearOfApprenticeship) :
        base(firstname, lastname, isMen, isDiasabled, ahv, companyPhoneNr, employeeNr, department, entry, levelOfEmployment, function, squadLevel)
        {
            NumberOfApprenticeship = numberOfApprenticeship;
            CurrentYearOfApprenticeship = getApprenticeshipYear();

        }


        public int getApprenticeshipYear()
        {
            int anzahlTage = Convert.ToInt32(DateTime.Now - Entry);

            if (anzahlTage < 365)
                return 1;
            if (anzahlTage > 365 && anzahlTage < 736)
                return 2;
            if (anzahlTage > 736 && anzahlTage < 1101)
                return 3;
            else
                return 4;

        }

    }
}
