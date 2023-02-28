using Microsoft.EntityFrameworkCore;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Wrappers;
using TaskManager.Persistence.Context;

namespace TaskManager.Persistence.Business
{


    public class LocationDataWriter
    {
        readonly TaskManagerContext _context;
        private string _baseDir => System.AppContext.BaseDirectory.Split("\\src\\")[0] + "\\src\\Infrastructure\\TaskManager.Persistence\\SourceFiles\\Locations\\";
        public LocationDataWriter(TaskManagerContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse> InsertUT_Country()
        {

            var dir = _baseDir + "gadm36_TUR_0.json";
            var location = System.IO.File.ReadAllText(dir);

            var jsonReader = new GeoJsonReader();
            var features = jsonReader.Read<NetTopologySuite.Features.FeatureCollection>(location);
            if (features == null)
            {
                return new BaseResponse { Message = "features is null" };
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

            var res = await _context.SaveChangesAsync();

            return new BaseResponse { Success = res > 0 };

        }

        public async Task<BaseResponse> InsertUT_City()
        {

            var dir = _baseDir + "gadm36_TUR_1.json";
            var location = System.IO.File.ReadAllText(dir);

            var jsonReader = new GeoJsonReader();
            var features = jsonReader.Read<NetTopologySuite.Features.FeatureCollection>(location);
            if (features == null)
            {
                return new BaseResponse { Message = "features is null" };
            }

            foreach (var feature in features)
            {

                var item = new UtCity
                {
                    Name = feature.Attributes["NAME_1"].ToString(),
                    Shape = feature.Geometry,
                };

                var rs = await _context.UtCities.AddAsync(item);

            }

            var res = await _context.SaveChangesAsync();

            return new BaseResponse { Success = res > 0 };

        }

        public async Task<BaseResponse> InsertUT_Town()
        {

            var dir = _baseDir + "gadm36_TUR_2.json";
            var location = System.IO.File.ReadAllText(dir);

            var jsonReader = new GeoJsonReader();
            var features = jsonReader.Read<NetTopologySuite.Features.FeatureCollection>(location);
            if (features == null)
            {
                return new BaseResponse { Message = "features is null" };
            }

            var cities = await _context.UtCities.ToListAsync();

            foreach (var feature in features)
            {

                var item = new UtTown
                {
                    Name = feature.Attributes["NAME_2"].ToString(),
                    Shape = feature.Geometry,
                    CityId = cities.Where(a => a.Name == feature.Attributes["NAME_1"].ToString()).FirstOrDefault().Id
                };

                var rs = await _context.UtTowns.AddAsync(item);

            }

            var res = await _context.SaveChangesAsync();

            return new BaseResponse { Success = res > 0 };

        }

    }
}
