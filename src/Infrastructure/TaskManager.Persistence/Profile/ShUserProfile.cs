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
            //  CreateMap<ShUser, ShUserModel>()
            //      .ReverseMap();

            //  CreateMap<ShUserDTO, ShUserModel>(MemberList.Destination);

            //  CreateMap<ShUserDTO, ShUserModel>()
            //      .ForPath(destination => destination.Data, member => member.MapFrom(source => source))
            //      .ReverseMap();

            CreateMap<ShUserDTO, ShUser>()
                .ReverseMap();



        }
    }
}
