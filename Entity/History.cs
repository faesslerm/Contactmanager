using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactmanager
{
    class History
    {
        //Properties:

        public DateTime Editing { get; set; }
        public string Target { get; set; } //Was wurde geändert? vgl. Note unten

        //Konstruktor:
        public History(DateTime editing, string target)
        {
            Editing = editing;
            Target = target;
        }

        //Methode zur Überprüng, was geändert wurde --> mit SwitchCase bspw. Adressänderung oderso?
    }
}
