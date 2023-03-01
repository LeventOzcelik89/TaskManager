using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Persistence.Business.Interface
{
    public interface IBusinessBase
    {
        void Load(Guid Id);
        void Delete(Guid Id);
        void Insert();
        void Update();
    }
}
