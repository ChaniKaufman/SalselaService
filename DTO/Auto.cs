using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DTO
{
    public class Auto : AutoMapper.Profile
    {
        public Auto()
        {
            CreateMap<Tbook, DashboardDto>();
            CreateMap<DashboardDto, Tbook>();

     
        }
    }
}
