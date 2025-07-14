using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pollkit_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> DemoGetFunction()
        {
            return Ok("Demo Get Function");
        }
    }
}