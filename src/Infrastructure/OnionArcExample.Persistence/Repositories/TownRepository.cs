using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Domain.Entities;
using OnionArcExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence.Repositories
{
    public class TownRepository : Repository<UT_Town>, ITownRepository
    {
        public TownRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
