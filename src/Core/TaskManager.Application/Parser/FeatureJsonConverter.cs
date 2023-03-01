using NetTopologySuite.Features;
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
    public class FeatureJsonConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(Feature).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var feature = new Feature();
            feature.Attributes = new AttributesTable();
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = reader.Value.ToString();
                    if (propertyName == "shape")
                    {
                        reader.Read();
                        var shape = serializer.Deserialize<Geometry>(reader);
                        feature.Geometry = shape;
                    }
                    else
                    {
                        reader.Read();
                        var value = serializer.Deserialize(reader);
                        feature.Attributes.Add(propertyName, value);
                    }
                }
                else if (reader.TokenType == JsonToken.EndObject)
                    break;
            }
            return feature;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                var feature = (IFeature)value;

                var geoJsonWriter = new GeoJsonWriter();
                var json = geoJsonWriter.Write(feature);
                writer.WriteRawValue(json);
            }
            else serializer.Serialize(writer, value);
        }
    }
}
