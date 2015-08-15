using LolApp.Common.ChampionInfo;
using LolApp.Common.StaticData;
using LolApp.Common.StaticData.Champion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace LolApp.Common.RiotAPI.API
{
    public class StaticData<T> : APIBase<T>
    {

        private static readonly string version = "v1.2";
        private static readonly string url = "static-data";

        private int? EntityId;

        public override string RequestURL
        {
            get
            {
                string ret = string.Format(RequestBuilder.API_URL, "global");
                ret = ret + "api/lol/" + url + "/{0}/" + version + "/" +getUrlString(typeof(T));
                if (EntityId != null)
                    ret = ret + "/" + EntityId.ToString();
                return string.Format(ret + "?" + string.Join("&", Parameters), Regions.All[Region ?? 6]);
            }
        }

        public StaticData()
        {
            Parameters = new List<string>();
        }

        public StaticData(int? region, int? entityId = null, string locale = null, string ver = null, string data = null, bool dataById = true) : this()
        {
            Region = region ?? -1;
            if (entityId != null) EntityId = entityId; else if (dataById) Parameters.Add("dataById="+dataById.ToString());
            if (locale != null) Parameters.Add("locale="+locale);
            if (ver != null) Parameters.Add("version=" + ver);
            if (data != null) Parameters.Add("champData=" + data);
            Parameters.Add(RequestBuilder.API_KEY);
        }

        private string getUrlString(Type genType)
        {
            if (genType == typeof(ChampionDto) || genType == typeof(ChampionListDto))
            {
                return "champion";
            }
            throw new Exception("Unsupported type for StaticData API");
        }

        public override List<T> Execute(Stream stream)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new RangeConverter());

            using (var reader = new StreamReader(stream))
            {
                var result = new List<T>();
                result.Add(JsonConvert.DeserializeObject<T>(reader.ReadToEnd(), settings));
                return result;

            }

        }
    }
}
