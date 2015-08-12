using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolApp.Common.RiotAPI
{
    public abstract class APIBase
    {
        public abstract string RequestURL { get; }

        public abstract List<String> Parameters { get; }

        public abstract void Execute();
    }
}
