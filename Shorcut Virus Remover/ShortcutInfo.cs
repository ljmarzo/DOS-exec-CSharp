﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorcut_Virus_Remover
{
    public class ShortcutInfo
    {
        //Login & Retrieve Info
        public string Username { get; set; }
        public string Password { get; set; }

        //Log History
        public DateTime LogHistory { get; set; }

        //Scan History
        public DateTime ScanHistory { get; set; }


    }
}
