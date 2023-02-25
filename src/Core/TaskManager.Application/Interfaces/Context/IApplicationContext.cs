using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<UT_Country> UT_Country { get; set; }
        DbSet<UT_City> UT_City { get; set; }
        DbSet<UT_Town> UT_Town { get; set; }
        DbSet<SH_User> SH_User { get; set; }

    }
}
