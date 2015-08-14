using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LolApp.Common.ChampionInfo
{
    [DataContract]
    public class ChampionInfoDto : ILolDto
    {
        [DataMember]
        public bool botMmEnabled;

        [DataMember]
        public int id;

        [DataMember]
        public bool rankedPlayEnabled;

        [DataMember]
        public bool botEnabled;

        [DataMember]
        public bool active;

        [DataMember]
        public bool freeToPlay;

    }

    [DataContract]
    public class ListChampionInfoDto
    {
        [DataMember]
        public List<ChampionInfoDto> champions;
    }


}
