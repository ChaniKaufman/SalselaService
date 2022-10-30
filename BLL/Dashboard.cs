using AutoMapper;
using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class Dashboard: IDasboardBll
    {
        IDashboardDal _IDashDal;
        IMapper _imapper;

        public Dashboard(IDashboardDal DashboardDal)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();

            });
            _imapper = config.CreateMapper();
            _IDashDal = DashboardDal;
        }

        public List<DashboardDto> GetAllDashboard()
        {
            List<Tbook> c = _IDashDal.GetAllDasboard();

            return _imapper.Map<List<Tbook>, List<DashboardDto>>(c);
        }

        
    }
}
