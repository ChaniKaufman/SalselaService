using AutoMapper;
using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class LoginBll:ILoginBll
    {
        ILoginDal _ILoginDal;
        IMapper _imapper;

        public LoginBll(ILoginDal LoginDal)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();

            });
            _imapper = config.CreateMapper();
            _ILoginDal = LoginDal;
        }

        public UserDto Login(string nvUserName,string nvPassword)
        {
           Tuser user= _ILoginDal.Login(nvUserName, nvPassword);

            return _imapper.Map<Tuser,UserDto>(user);
        }
    }
}
