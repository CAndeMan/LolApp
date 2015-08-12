using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolApp.Common.Riot.API
{
    public abstract class APIBase
    {
        public abstract string RequestURL { get; }

        public abstract void Execute();
    }
}
