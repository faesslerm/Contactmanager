using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactmanager
{
    [Serializable]
    public class History
    {
        //Properties:
        public DateTime Editing { get; set; }
        public string Target { get; set; } //Was wurde geändert? vgl. Note unten --> bspw. Vorname
        public string Oldvalue { get; set; } // Alter Wert

        //Konstruktor:
        public History(DateTime editing, string target, string oldvalue)
        {
            Editing = editing;
            Target = target;
            Oldvalue = oldvalue;
        }

        public override string ToString()
        {
            return $"Datum: {Editing.ToString()} Feld: {Target} Alter Wert: {Oldvalue}";
        }
    }
}
