using AutoMapper;
using FInancingManager.Entities;
using FInancingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInancingManager.AutoMapper
{
    public class UserAutomapperProfile : Profile
    {
        public UserAutomapperProfile()
        {
            // SignUpModel -> UserEntity
            CreateMap<SignUpModel, UserEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName));

            // UserEntity -> UserModel
            CreateMap<UserEntity, UserModel>();
        }
    }
}
