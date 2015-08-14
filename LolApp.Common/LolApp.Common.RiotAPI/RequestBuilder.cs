using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace LolApp.Common.RiotAPI
{
    public static class RequestBuilder
    {
        public static readonly string API_KEY = "api_key=8ad1252f-1789-49e3-a880-7c828cde0ccd";
        public static readonly string API_URL = "https://{0}.api.pvp.net/";

        public static List<T> ExecuteAndReturn<T>(this APIBase<T> api)
        {
            try
            {
                if (api.Region == -1)
                {
                    List<T> master = new List<T>();
                    foreach (Region reg in Enum.GetValues(typeof(Region)))
                    {
                        api.Region = (int)reg;
                        master.AddRange(Execute(api));
                    }
                    return master;
                }
                else
                {
                    return Execute(api);
                }

            }
            catch
            {
                throw; // Something happened...
            }
        }

        private static List<T> Execute<T>(APIBase<T> api)
        {
            WebRequest request = WebRequest.Create(api.RequestURL);
            var res = request.GetResponse();

            using (var stream = res.GetResponseStream())
            {
                return api.Execute(stream);
            }
        }
    }
}


