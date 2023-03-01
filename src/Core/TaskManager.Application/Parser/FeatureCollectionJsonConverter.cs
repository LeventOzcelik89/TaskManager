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
    public class FeatureCollectionJsonConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(FeatureCollection).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            FeatureCollection collection = new FeatureCollection();
            collection.BoundingBox = new Envelope();
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    if (reader.Path == "features")
                    {
                        reader.Read();
                        if (reader.TokenType == JsonToken.StartArray)
                        {
                            while (reader.Read())
                            {
                                if (reader.TokenType == JsonToken.EndArray)
                                    break;
                                var feature = serializer.Deserialize<Feature>(reader);
                                collection.Add(feature);
                                if (feature != null && feature.Geometry != null)
                                    collection.BoundingBox = collection.BoundingBox.ExpandedBy(feature.Geometry.EnvelopeInternal);
                            }
                        }
                    }
                }
            }
            return collection;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                var collection = (FeatureCollection)value;
                var geoJsonWriter = new GeoJsonWriter();
                var json = geoJsonWriter.Write(collection);
                writer.WriteRawValue(json);
            }
            else serializer.Serialize(writer, value);
        }
    }
}
