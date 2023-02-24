﻿using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Domain.Entities;
using OnionArcExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence.Repositories
{
    public class CountryRepository : Repository<UT_Country>, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}