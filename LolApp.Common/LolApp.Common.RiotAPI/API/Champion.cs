using LolApp.Common.ChampionInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace LolApp.Common.RiotAPI.API
{
    public class Champion : APIBase<ChampionInfoDto>
    {

        private static readonly string version = "v1.2";
        private static readonly string url = "champion";

        private int? ChampionId;
        private bool FreeToPlay;

        public override string RequestURL
        {
            get
            {
                string ret = RequestBuilder.API_URL;
                ret = ret + "api/lol/{0}/" + version + "/" + url;
                if (ChampionId != null)
                    ret = ret + "/" + ChampionId.ToString();
                if (FreeToPlay) Parameters.Add("freeToPlay=true");
                Parameters.Add(RequestBuilder.API_KEY);
                return string.Format(ret + "?" + string.Join("&", Parameters), Regions.All[Region ?? 6]);
            }
        }

        public Champion(){
            Parameters = new List<String>();
        }

        public Champion(int? region, int? championId = null) : this()
        {
            Region = region ?? -1;
            ChampionId = championId;
        }

        public Champion(int? region, bool free = false) : this()
        {
            Region = region ?? -1;
            FreeToPlay = free;
        }

        public override List<ChampionInfoDto> Execute(Stream stream)
        {
            if (ChampionId == null)
            {
                var ser = new DataContractJsonSerializer(typeof(ListChampionInfoDto));
                var champ = (ListChampionInfoDto)ser.ReadObject(stream);
                return champ.champions;
            }
            else
            {
                var ser = new DataContractJsonSerializer(typeof(ChampionInfoDto));
                var champ = (ChampionInfoDto)ser.ReadObject(stream);
                return new List<ChampionInfoDto>() { champ };
            }
        }
    }
}
