using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.Parser
{
    public class EnvelopeJsonConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Envelope).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) return null;
            var wktReader = new WKTReader();
            var result = wktReader.Read(reader.Value.ToString()).EnvelopeInternal;
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
                serializer.Serialize(writer, GetGeometry((Envelope)value).AsText());
            else serializer.Serialize(writer, value);
        }

        public static Geometry GetGeometry(Envelope env)
        {
            GeometryFactory factory = NetTopologySuite.NtsGeometryServices.Instance.CreateGeometryFactory();
            return factory.CreatePolygon(new Coordinate[]
            {
                new Coordinate { X = env.MinX, Y = env.MaxY },
                new Coordinate { X = env.MinX, Y = env.MinY },
                new Coordinate { X = env.MaxX, Y = env.MinY },
                new Coordinate { X = env.MaxX, Y = env.MaxY },
                new Coordinate { X = env.MinX, Y = env.MaxY },
            });
        }
    }
}
