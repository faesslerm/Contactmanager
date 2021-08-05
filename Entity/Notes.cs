﻿using System;

namespace Contactmanager
{
    [Serializable]
    public class Notes
    {
        public DateTime TimeStamp { get; set; }
        public string Comment { get; set; }

        public Notes(DateTime timeStamp)
        {
            TimeStamp = timeStamp;
            Comment = string.Empty; // anstatt ""
        }
    }
}
