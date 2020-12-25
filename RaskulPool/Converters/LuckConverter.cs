using Newtonsoft.Json;
using RaskulPool.Models;
using System;

namespace RaskulPool.Converters
{
    internal class LuckConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Luck) || t == typeof(Luck?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0.000":
                    return Luck.The0000;
                case "NaN":
                    return Luck.NaN;
            }
            throw new Exception("Cannot unmarshal type Luck");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Luck)untypedValue;
            switch (value)
            {
                case Luck.The0000:
                    serializer.Serialize(writer, "0.000");
                    return;
                case Luck.NaN:
                    serializer.Serialize(writer, "NaN");
                    return;
            }
            throw new Exception("Cannot marshal type Luck");
        }

        public static readonly LuckConverter Singleton = new LuckConverter();
    }
}