using Microsoft.EntityFrameworkCore;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Persistence.Context;

namespace TaskManager.Persistence.Business
{


    public class LocationDataWriter
    {
        readonly TaskManagerContext _context;
        public LocationDataWriter(TaskManagerContext context)
        {
            _context = context;
        }

        public async Task<bool> InsertUT_Location()
        {

            var dir = @"D:\Projects\TaskManager\TaskManager\src\Presentation\TaskManager.WebAPI\SourceFiles\Locations\gadm36_TUR_0.json";
            var location = System.IO.File.ReadAllText(dir);

            var jsonReader = new GeoJsonReader();
            var features = jsonReader.Read<NetTopologySuite.Features.FeatureCollection>(location);
            if (features == null)
            {
                return false;
            }

            foreach (var feature in features)
            {

                var item = new UtCountry
                {
                    Name = feature.Attributes["NAME_0"].ToString(),
                    Shape = feature.Geometry
                };

                var rs = await _context.UtCountries.AddAsync(item);

            }

            _context.SaveChanges();

            return true;

        }



    }
}
