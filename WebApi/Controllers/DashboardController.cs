using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        IDasboardBll _DashboardBll;
        public DashboardController(IDasboardBll _DashboardBll)
        {
            this._DashboardBll = _DashboardBll;
        }

        //שליפת רשימת כל קטגוריות
        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            return Ok(_DashboardBll.GetAllDashboard());
        }

    }
}