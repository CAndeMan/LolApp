using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LolApp.Common.RiotAPI
{
    public abstract class APIBase<T>
    {
        public int? Region { get; set; }

        public abstract string RequestURL { get; }

        protected List<String> Parameters;

        public abstract List<T> Execute(Stream stream);

    }
}
