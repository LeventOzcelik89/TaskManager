using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Wrappers;
using TaskManager.Persistence.Business.Interface;
using TaskManager.Persistence.Context;

namespace TaskManager.Persistence.Business.Abstract
{
    public abstract class BusinessBase<T>
    {
        [JsonIgnore]
        public TaskManagerContext _context { get; private set; }
        public T Data { get; set; }

        protected BusinessBase(TaskManagerContext context)
        {
            this._context = context;
        }

        public virtual async Task<BaseResponse> Load(Guid Id) { throw new NotImplementedException(); }

        public virtual async Task<BaseResponse> Insert() { throw new NotImplementedException(); }

        public virtual async Task<BaseResponse> Update() { throw new NotImplementedException(); }

        public virtual async Task<BaseResponse> Delete(Guid? Id) { throw new NotImplementedException(); }

    }
}
