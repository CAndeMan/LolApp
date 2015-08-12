using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LolApp.Common.RiotAPI.API
{
    public class Champion : APIBase
    {

        private static readonly string version = "v1.2";
        private static readonly string url = "champion";

        private bool freeToPlay;

        public override string RequestURL
        {
            get
            {
                return "api/lol/na/" + version + "/" + url;
            }
        }

        public override List<String> Parameters
        {
            get
            {
                return new List<String> { "freeToPlay=" + freeToPlay.ToString() };
            }
        }

        public Champion(bool free = false)
        {
            freeToPlay = free;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
