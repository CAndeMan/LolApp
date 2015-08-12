using System.Collections.Generic;
using System.IO;
using System.Net;

namespace LolApp.Common.RiotAPI
{
    public static class RequestBuilder
    {
        private static readonly string API_KEY = "api_key=8ad1252f-1789-49e3-a880-7c828cde0ccd";
        private static readonly string API_URL = "https://na.api.pvp.net/";

        public static void ExecuteAndReturn(this APIBase api)
        {
            var args = api.Parameters;
            args.Add(API_KEY);
            string connection = API_URL + api.RequestURL + "?" + string.Join("&", args);

            try
            {
                WebRequest req = WebRequest.Create(connection);
                var res = req.GetResponse();
                using (var stream = res.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        var jsonO = sr.ReadToEnd();
                    }
                }
            }
            catch
            {

            }

        }
    }
}
