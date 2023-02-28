//using Microsoft.AspNetCore.Http.Features;
//using Microsoft.AspNetCore.Mvc;
//using NetTopologySuite.IO;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using TaskManager.Application.Interfaces.Repositories;
////using TaskManager.Domain.Entities;
//using TaskManager.Persistence.Context;

//namespace TaskManager.WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class WorkerController : Controller
//    {

//        readonly TaskManagerContext _context;
//        public WorkerController(TaskManagerContext context) => _context = context;

//        [HttpGet]
//        public async Task<IActionResult> InsertCountry()
//        {

//            var rs = await _context.UtCountries.AddAsync(new UtCountry
//            {
//                Created = DateTime.Now,
//                Name = "Test"
//            });

//            //var dir0 = @"D:\Projects\TaskManager\TaskManager\src\Presentation\TaskManager.WebAPI\SourceFiles\Locations\gadm36_TUR_0.json";
//            //var location = System.IO.File.ReadAllText(dir0);

//            //var jsonReader = new GeoJsonReader();
//            //var features = jsonReader.Read<NetTopologySuite.Features.FeatureCollection>(location);
//            //if (features == null)
//            //{
//            //    return null;
//            //}

//            //foreach (var feature in features)
//            //{

//            //    var item = new UT_Country
//            //    {
//            //        Name = feature.Attributes["NAME_0"].ToString(),
//            //        //  Shape = feature.Geometry
//            //    };

//            //    _countryRepository.AddAsync(item);

//            //}
//            _context.SaveChanges();

//            return Ok("done");
//        }


//    }
//}
