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
    public class CodeTableController : ControllerBase
    {
        ICodeTableBll _CodeTableBll;
        public CodeTableController(ICodeTableBll CodeTableBll)
        {
            this._CodeTableBll = CodeTableBll;
        }
        //הפונקציה מחזירה את שמות סוגי המשתמשים עם הקודים
        [HttpGet("GetAuthorizationTypes")]
        public IActionResult GetAuthorizationTypes()
        {
            return Ok(_CodeTableBll.GetAuthorizationTypes());
        }

    }
}