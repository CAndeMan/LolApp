using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolApp.Common.Champion
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class ChampionDto
    {

        public int id { get; set; }
        public bool active { get; set; }
        public bool botEnabled { get; set; }
        public bool freeToPlay { get; set; }
        public bool botMmEnabled { get; set; }
        public bool rankedPlayEnabled { get; set; }

        public ChampionDto()
        {

        }
    }
}
