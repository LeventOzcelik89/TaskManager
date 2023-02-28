using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManager.Persistence.Business;
//using TaskManager.Domain.Entities;
using TaskManager.Persistence.Context;

namespace TaskManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    
    public class WorkerController : ControllerBase
    {

        readonly TaskManagerContext _context;
        public WorkerController(TaskManagerContext context) => _context = context;

        [HttpGet("~/InsertCountry")]
        public async Task<IActionResult> InsertCountry()
        {

            var rs = await new LocationDataWriter(_context).InsertUT_Country();

            return Ok(rs);
        }


        [HttpGet("~/InsertCity")]
        public async Task<IActionResult> InsertCity()
        {

            var rs = await new LocationDataWriter(_context).InsertUT_City();

            return Ok(rs);
        }

        [HttpGet("~/InsertTown")]
        public async Task<IActionResult> InsertTown()
        {

            var rs = await new LocationDataWriter(_context).InsertUT_Town();

            return Ok(rs);
        }

    }
}
