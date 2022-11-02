using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface ILoginBll
    {
        public UserDto Login(string nvUserName, string nvPassword);
    }
}
