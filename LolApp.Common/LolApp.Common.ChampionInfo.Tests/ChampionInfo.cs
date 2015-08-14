using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Runtime.Serialization.Json;

namespace LolApp.Common.ChampionInfo.Tests
{
    [TestClass]
    public class ChampionInfo
    {
        [TestMethod]
        public void TestChampSerialize()
        {
            string json = "{\"botMmEnabled\": true,\"id\": 1,\"rankedPlayEnabled\": true,\"botEnabled\": true,\"active\": true,\"freeToPlay\": false}";
            MemoryStream str = new MemoryStream();
            str.Write(System.Text.Encoding.Default.GetBytes(json), 0, json.Length);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ChampionInfoDto));
            str.Position = 0;
            ChampionInfoDto champ = (ChampionInfoDto)ser.ReadObject(str); 



        }
    }
}
