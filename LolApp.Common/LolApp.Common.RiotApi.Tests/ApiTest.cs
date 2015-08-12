using System;
using LolApp.Common.RiotAPI;
using LolApp.Common.RiotAPI.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LolApp.Common.RiotAPI.Tests
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void TestRequestBuilder()
        {
            var champ = new Champion(false);
            RequestBuilder.ExecuteAndReturn(champ);
        }
    }
}
