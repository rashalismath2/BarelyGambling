using AutoMapper;
using BarelyGambling.API.Dto;
using BarelyGambling.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser,UserDto>();
            CreateMap<RegisterUserDto, AppUser>()
                .ForMember(
                    dest=>dest.UserName,
                    opt=>opt.MapFrom(src=>src.Email)
                );
        }
    }
}
