using LolApp.Common.RiotAPI;
using LolApp.Common.RiotAPI.API;
using LolApp.Common.StaticData.Champion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolApp.Models
{
    public class ChampionDataModel
    {
        public ChampionDto champ;

        public ChampionDataModel(int champId)
        {
            var qry = new StaticData<ChampionDto>(6, champId, null, null, "all");
            var list = RequestBuilder.ExecuteAndReturn(qry);
            champ = list.First();

        }
    }
}