using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LolApp.Common.StaticData.Champion
{
    public class ChampionDto
    {
        public List<string> allytips;
        public string blurb;
        public List<string> enemytips;
        public int id;
        public ImageDto image;
        public InfoDto info;
        public string key;
        public string lore;
        public string name;
        public string partype;
        public PassiveDto passive;
        public List<RecommendedDto> recommended;
        public List<SkinDto> skins;
        public List<ChampionSpellDto> spells;
        public StatsDto stats;
        public List<string> tags;
        public string title;
    }

    public class ChampionListDto
    {
        public Dictionary<int, ChampionDto> data;
        public string format;
        public Dictionary<string, string> keys;
        public string type;
        public string version;
    }


    public class SkinDto
    {
        public int id;
        public string name;
        public int num;
    }

    public class ChampionSpellDto
    {
        public List<ImageDto> altimages;
        public List<double> cooldown;
        public string cooldownBurn;
        public List<int> cost;
        public string costburn;
        public string costType;
        public string description;
        public List<List<double>> effect;
        public List<string> effectBurn;
        public ImageDto image;
        public string key;
        public LevelTipDto leveltip;
        public int maxrank;
        public string name;
        public Range range;
        public string rangeBurn;
        public string resource;
        public string sanitizedDesciption;
        public string sanitizedTooltip;
        public string tooltip;
        public List<SpellVarsDto> vars;
    }

    public class SpellVarsDto
    {
        public List<double> coeff;
        public string dyn;
        public string key;
        public string link;
        public string ranksWith;
    }

    public class LevelTipDto
    {
        public List<string> effect;
        public List<string> label;
    }

    public class StatsDto
    {
        public double armor;
        public double armorperlevel;
        public double attackdamage;
        public double attackdamageperlevel;
        public double attackrange;
        public double attackspeedoffset;
        public double attackspeedperlevel;
        public double crit;
        public double critperlevel;
        public double hp;
        public double hpperlevel;
        public double hpregen;
        public double hpregenperlevel;
        public double movespeed;
        public double mp;
        public double mpperlevel;
        public double mpregen;
        public double mpregenperlevel;
        public double spellblock;
        public double spellblockperlevel;
    }

    public class RecommendedDto
    {
        public List<BlockDto> blocks;
        public string champion;
        public string map;
        public string mode;
        public bool priority;
        public string title;
        public string type;
    }

    public class BlockDto
    {
        public List<BlockItemDto> items;
        public bool recMath;
        public string type;
    }

    public class BlockItemDto
    {
        public int count;
        public int id;
    }

    public class PassiveDto
    {
        public string description;
        public ImageDto image;
        public string name;
        public string sanitizedDescription;
    }

    public class InfoDto
    {
        public int attack;
        public int defense;
        public int difficulty;
        public int magic;
    }

    public class ImageDto
    {
        public string full;
        public string group;
        public int h;
        public string sprite;
        public int w;
        public int x;
        public int y;
    }

    public class ListChampionInfoDto
    {
        public Dictionary<int, string> keys;
        
    }

    public class Range
    {
        public List<int> Ranges;
        public string Value;
    }

    public class RangeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Range);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                return new Range
                {
                    Value = (string)reader.Value,
                };
            }

            return new Range
            {
                Ranges = serializer.Deserialize<List<int>>(reader),
            };
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Don't need to serialize
            throw new NotImplementedException();
        }
    }
}


