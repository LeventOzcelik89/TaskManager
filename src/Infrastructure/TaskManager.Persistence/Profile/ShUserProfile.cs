using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Dto;
using TaskManager.Persistence.Business;
using TaskManager.Persistence.Context;

namespace TaskManager.Persistence
{
    public class ShUserProfile : Profile
    {
        public ShUserProfile()
        {
            CreateMap<ShUser, ShUserModel>()
                .ReverseMap();

            CreateMap<ShUserDTO, ShUserModel>()
                .ReverseMap();

            CreateMap<ShUserDTO, ShUser>()
                .ReverseMap();
            
        }
    }
}
