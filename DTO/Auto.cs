using System;
using System.Collections.Generic;
using System.Text;
using DAL.Classes;
using DAL.Models;

namespace DTO
{
    public class Auto : AutoMapper.Profile
    {
        public Auto()
        {
            CreateMap<CodeTable, CodeTableDto>();
            CreateMap<CodeTableDto, CodeTable>();

            CreateMap<Tuser,UserDto>();
            CreateMap<UserDto, Tuser>();





        }
    }
}
