using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactmanager
{
    public class Notes
    {
        public DateTime TimeStamp { get; set; }
        public string Comment { get; set; }

        public Notes(DateTime timeStamp)
        {
            TimeStamp = timeStamp;
            Comment = "";
        }

    }
}
