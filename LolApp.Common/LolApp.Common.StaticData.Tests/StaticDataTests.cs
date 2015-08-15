using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LolApp.Common.StaticData.Champion;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;
using LolApp.Common.RiotAPI.API;
using LolApp.Common.RiotAPI;
using System.Collections.Generic;
using LolApp.Common.StaticData.Extensions;

namespace LolApp.Common.StaticData.Tests
{
    [TestClass]
    public class StaticDataTests
    {

        public static string championFilePath = @"C:\LolApp\LolApp.Common\LolApp.Common.StaticData.Tests\Texts\champion-dto-4.txt";

        [TestMethod]
        public void ChampionDtoTests()
        {
            var ser = new DataContractJsonSerializer(typeof(ChampionDto));
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new RangeConverter());
            //settings.
            using (var file = new StreamReader(championFilePath)){
                //ChampionDto champ = (ChampionDto)ser.ReadObject(file);
                ChampionDto champ2 = JsonConvert.DeserializeObject<ChampionDto>(file.ReadToEnd(), settings);
            }
        }

        [TestMethod]
        public void ChampionApiTest()
        {
            var api = new StaticData<ChampionDto>(6, 4, null, null, "all");

            var images = QueryExecutor.getChampionImages();

            try
            {
                List<ChampionDto> list = RequestBuilder.ExecuteAndReturn(api);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
