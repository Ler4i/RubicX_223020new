using AutoMapper;
using RubicX_223020new.BusinessLogic.Core.Models;
using RubicX_223020new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubicX_223020new.Automapper
{
    public class MicroservicePrifile : Profile
    {
        public MicroservicePrifile()
        {
            CreateMap<UserInformationBlo, UserInformationDto>();
            //CreateMap<UserUpdateBlo, UserUpdateDto>();
            CreateMap<UserUpdateDto, UserUpdateBlo>();
        }
    }
}
