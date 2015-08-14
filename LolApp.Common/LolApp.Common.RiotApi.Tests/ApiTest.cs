using System;
using LolApp.Common.RiotAPI;
using LolApp.Common.RiotAPI.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LolApp.Common.ChampionInfo;
using System.Collections.Generic;

namespace LolApp.Common.RiotAPI.Tests
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void TestRequestBuilder()
        {
            var champ = new Champion(null, false);
            try
            {
                RequestBuilder.ExecuteAndReturn(champ);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }     
        }

        [TestMethod]
        public void TestExecuteAndReturn()
        {
            var champ = new Champion((int) Region.NA, 1);
            try
            {
                List<ChampionInfoDto> list = RequestBuilder.ExecuteAndReturn(champ);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }




    }
}
