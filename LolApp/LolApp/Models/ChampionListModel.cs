using LolApp.Common.ChampionInfo;
using LolApp.Common.RiotAPI;
using LolApp.Common.RiotAPI.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolApp.Models
{
    public class ChampionListModel
    {
        public List<ChampionInfoDto> list;

        public ChampionListModel()
        {
            var qry = new Champion();
            list = RequestBuilder.ExecuteAndReturn(qry);
        }

    }
}