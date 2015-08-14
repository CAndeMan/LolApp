using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Common.StaticData
{
    public interface IStaticData
    {
        string GetType();
    }

    public static class StaticDataExtension
    {
        public static string getType(this IStaticData data)
        {
            return data.GetType();
        }

    }
}
