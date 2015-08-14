using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Common
{
    public enum Region
    {
        BR = 0,
        EUNE = 1,
        EUW = 2,
        KR = 3,
        LAN = 4,
        LAS = 5,
        NA = 6,
        OCE = 7,
        RU = 8,
        TR = 9
    }

    public static class Regions
    {
        public static string[] All = new string[]
            {
                "br",
                "eune",
                "euw",
                "kr",
                "lan",
                "las",
                "na",
                "oce",
                "ru",
                "tr"
            };

    }
}