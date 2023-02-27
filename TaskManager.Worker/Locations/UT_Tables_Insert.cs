using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces.Repositories;
using TaskManager.Domain.Entities;
using TaskManager.Persistence.Repositories;

namespace TaskManager.Worker.Locations
{
    public class UT_Tables_Insert
    {

        public void Run(ICountryRepository countryRepository)
        {

            var dir0 = @"D:\Projects\TaskManager\TaskManager\src\Presentation\TaskManager.WebAPI\SourceFiles\Locations\gadm36_TUR_0.json";
            var location = System.IO.File.ReadAllText(dir0);

            var jsonReader = new GeoJsonReader();
            var features = jsonReader.Read<FeatureCollection>(location);
            if (features == null)
            {
                return;
            }

            foreach (var feature in features)
            {

                var item = new UT_Country
                {
                    Name = feature.Attributes["NAME_0"].ToString(),
                    Shape = feature.Geometry
                };

                 .AddAsync(item);

                //var txt = feature.Geometry.AsText();
                //var names = feature.Attributes.GetNames();
                //var values = feature.Attributes.GetValues();
                //var xx = feature.Attributes.Exists("NAME_0");


            }



            //  var serializer = GeoJsonSerializer.Create();
            //  using (var stringWriter = new StringWriter())
            //  using (var jsonWriter = new JsonTextWriter(stringWriter))
            //  {
            //      serializer.Serialize(jsonWriter, geometry);
            //      geoJson = stringWriter.ToString();
            //  }


        }

    }
}
