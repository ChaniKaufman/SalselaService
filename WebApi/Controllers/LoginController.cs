using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILoginBll _LoginBll;
        public LoginController(ILoginBll LoginBll)
        {
            this._LoginBll = LoginBll;
        }
        //הפונקציה מחזירה את שמות סוגי המשתמשים עם הקודים
        [HttpGet("Login/")]
        public IActionResult Login([FromQuery] string nvUserName, string nvPassword)
        {
            return Ok(_LoginBll.Login(nvUserName, nvPassword));
        }
    }
}