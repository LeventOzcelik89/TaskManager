using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Persistence.Business;
using TaskManager.Persistence.Context;

namespace TaskManager.WebAPI.Controllers
{

    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        readonly TaskManagerContext _context;
        public UserController(TaskManagerContext context) => _context = context;

        [HttpPost("~/GetUser")]
        public async Task<IActionResult> GetUser(Guid Id)
        {

            var rs = new ShUserModel(_context);
            await rs.Load(Id);

            return Ok(rs);
        }

        [HttpPost("~/GetTown")]
        public async Task<IActionResult> GetTown(Guid Id)
        {

            var rs = await _context.UtTowns.Where(a => a.Id == Id).FirstOrDefaultAsync();
            
            return Ok(rs);
        }

    }
}
