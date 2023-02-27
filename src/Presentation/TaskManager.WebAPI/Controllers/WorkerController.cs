using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces.Repositories;
using TaskManager.Domain.Entities;

namespace TaskManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : Controller
    {

        readonly ICountryRepository _countryRepository;

        public WorkerController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> InsertCountry()
        {
            var dir0 = @"D:\Projects\TaskManager\TaskManager\src\Presentation\TaskManager.WebAPI\SourceFiles\Locations\gadm36_TUR_0.json";
            var location = System.IO.File.ReadAllText(dir0);

            var jsonReader = new GeoJsonReader();
            var features = jsonReader.Read<NetTopologySuite.Features.FeatureCollection>(location);
            if (features == null)
            {
                return null;
            }

            foreach (var feature in features)
            {

                var item = new UT_Country
                {
                    Name = feature.Attributes["NAME_0"].ToString(),
                    //  Shape = feature.Geometry
                };

                _countryRepository.AddAsync(item);

            }

            return Ok("done");
        }


    }
}
