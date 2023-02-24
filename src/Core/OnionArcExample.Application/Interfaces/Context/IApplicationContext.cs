using Microsoft.EntityFrameworkCore;
using OnionArcExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Interfaces.Context
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
