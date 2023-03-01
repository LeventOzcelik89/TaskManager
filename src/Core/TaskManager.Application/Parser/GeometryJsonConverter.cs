using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using System;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace TaskManager.Application.Parser
{
    public class GeometryJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Geometry).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) return null;
            var wktReader = new WKTReader();
            var result = wktReader.Read(reader.Value.ToString());
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
                serializer.Serialize(writer, ((Geometry)value).AsText());
            else serializer.Serialize(writer, value);
        }
    }

    //public class GeometryJsonConverter2 : System.Text.Json.Serialization.JsonConverter
    //{
    //    //public override bool CanConvert(Type objectType)
    //    //{
    //    //    return typeof(Geometry).IsAssignableFrom(objectType);
    //    //}



    //    //public override object ReadJson(JsonReader reader, Type objectType, object existingValue, System.Text.Json.Serialization.JsonSerializer serializer)
    //    //{
    //    //    if (reader.Value == null) return null;
    //    //    var wktReader = new WKTReader();
    //    //    var result = wktReader.Read(reader.Value.ToString());
    //    //    return result;
    //    //}

    //    //public override void WriteJson(JsonWriter writer, object value, System.Text.Json.Serialization.JsonSerializer serializer)
    //    //{
    //    //    if (value != null)
    //    //        serializer.Serialize(writer, ((Geometry)value).AsText());
    //    //    else serializer.Serialize(writer, value);
    //    //}
    //    public override bool CanConvert(Type typeToConvert)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

}
