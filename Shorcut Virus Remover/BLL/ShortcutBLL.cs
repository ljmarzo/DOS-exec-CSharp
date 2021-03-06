﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shorcut_Virus_Remover
{
    public abstract class ShortcutBLL
    {
        internal bool RetrieveData(ShortcutInfo shortcutinfo)
        {
            return RetrieveDataDAL(shortcutinfo);
        }
        internal void SaveLogHistory(ShortcutInfo shortcutinfo)
        {
            SaveLogHistoryDAL(shortcutinfo);
        }
        internal void SaveScanHistory(ShortcutInfo shortcutinfo)
        {
            SaveScanHistoryDAL(shortcutinfo);
        }
        internal void RetrieveDate(ShortcutInfo shortcutinfo)
        {
           RetrieveDateDAL(shortcutinfo);
        }
        protected abstract bool RetrieveDataDAL(ShortcutInfo shortcutinfo);
        protected abstract void RetrieveDateDAL(ShortcutInfo shortcutinfo);
        protected abstract void SaveLogHistoryDAL(ShortcutInfo shortcutinfo);
        protected abstract void SaveScanHistoryDAL(ShortcutInfo shortcutinfo);



        
    }
}
