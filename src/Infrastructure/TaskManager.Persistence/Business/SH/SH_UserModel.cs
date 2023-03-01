using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Wrappers;
using TaskManager.Persistence.Business.Abstract;
using TaskManager.Persistence.Context;

namespace TaskManager.Persistence.Business
{
    public class ShUserModel : ShUser
    {
        private TaskManagerContext _context;
        public ShUserModel(TaskManagerContext context) => _context = context;  //   : base(context) { }

        //public UtTown Town { get; set; }
        //public UtCity City { get; set; }

        public async Task<BaseResponse> Delete(Guid? Id)
        {
            _context.ShUsers.Remove(new ShUser { Id = Id.HasValue ? Id.Value : this.Id });
            var res = await _context.SaveChangesAsync();
            return new BaseResponse { Success = res > 0 };
        }

        public async Task<BaseResponse> Load(Guid Id)
        {
            var res = await _context.ShUsers.Where(a => a.Id == Id).FirstOrDefaultAsync();
            return new BaseResponse { Success = res != null };
        }

        public async Task<BaseResponse> Insert(ShUser item)
        {
            await _context.ShUsers.AddAsync(item);
            var res = await _context.SaveChangesAsync();
            return new BaseResponse { Success = res > 0 };
        }

        public async Task<BaseResponse> Update(ShUser item)
        {
            _context.ShUsers.Update(item);
            var res = await _context.SaveChangesAsync();
            return new BaseResponse { Success = res > 0 };
        }

    }
}
