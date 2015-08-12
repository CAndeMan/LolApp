using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolApp.Common.Riot.API.API
{
    public class Champion : APIBase
    {

        private static readonly string version = "v1.2";
        private static readonly string url = "champion";

        public override string RequestURL
        {
            get
            {
                return version + "/" + url;
            }
        }

        public Champion()
        {

        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
