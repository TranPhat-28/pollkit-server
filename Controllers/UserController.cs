using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pollkit_server.Services.UserService;

namespace pollkit_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<ServiceResponse<User>> GetUserById(int id)
        {
            try
            {
                var result = _userService.GetUserById(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                string controllerName = ControllerContext.ActionDescriptor.ControllerName;
                string methodName = ControllerContext.ActionDescriptor.ActionName;

                Console.WriteLine($"[Error] Error on {controllerName} at {methodName}");
                Console.WriteLine(e);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<int>>> CreateMockUser()
        {
            try
            {
                var result = await _userService.CreateMockUser();
                return Ok(result);
            }
            catch (Exception e)
            {
                string controllerName = ControllerContext.ActionDescriptor.ControllerName;
                string methodName = ControllerContext.ActionDescriptor.ActionName;

                Console.WriteLine($"[Error] Error on {controllerName} at {methodName}");
                Console.WriteLine(e);

                return StatusCode(500);
            }
        }
    }
}