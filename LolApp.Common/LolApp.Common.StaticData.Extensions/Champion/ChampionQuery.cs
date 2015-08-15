using LolApp.Common.RiotAPI;
using LolApp.Common.RiotAPI.API;
using LolApp.Common.StaticData.Champion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Common.StaticData.Extensions
{
    public static partial class QueryExecutor
    {
        public static List<ChampionDto> getChampions()
        {
            var qry = new StaticData<ChampionDto>(DEFAULT_REGION);
            return RequestBuilder.ExecuteAndReturn(qry);
        }

        public static ChampionDto getChampionAllById(int champId)
        {
            var qry = new StaticData<ChampionDto>(DEFAULT_REGION, champId, null, null, "all");
            var list = RequestBuilder.ExecuteAndReturn(qry);
            return list.First();
        }
    }
}
