using System;

namespace Contactmanager
{
    class Trainee : Employee
    {

        //Properties
        public int NumberOfApprenticeship { get; } // Dauer der Ausbildung
        public int CurrentYearOfApprenticeship { get; set; } // Aktuelles Ausbildungsjahr


        //Konstruktor:
        public Trainee(string firstname, string lastname, bool isMen, bool isDiasabled, Address address, string ahv, string companyPhoneNr, string department,
        DateTime entry, string levelOfEmployment, string function, byte squadLevel, int numberOfApprenticeship) :
        base(firstname, lastname, isMen, isDiasabled, address, ahv, companyPhoneNr, department, entry, levelOfEmployment, function, squadLevel)
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
