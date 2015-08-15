using LolApp.Common.ChampionInfo;
using LolApp.Common.RiotAPI;
using LolApp.Common.RiotAPI.API;
using LolApp.Common.StaticData.Champion;
using LolApp.Common.StaticData.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolApp.Models
{
    public class ChampionListModel
    {
        public List<ChampionDto> list;

        public ChampionListModel()
        {
            list = QueryExecutor.getChampionImages()
                .OrderBy(i => i.name)
                .ToList();
        }

    }
}