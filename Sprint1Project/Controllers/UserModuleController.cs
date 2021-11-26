using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint1Project.Models;
using Sprint1Project.Interface;

namespace Sprint1Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModuleController : ControllerBase
    {

        private readonly IUserModule _userModule;

        public UserModuleController(IUserModule userModule)
        {
            _userModule = userModule;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _userModule.GetAllUsers();
            return Ok(data);

        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult Get(int id)
        {
            var data = _userModule.GetUserById(id);
            if(data== null)
                return NotFound("No data Found");
            return Ok(data);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(UserModule user)
        {
            var data = _userModule.AddUser(user);
            if (data == null)
                return BadRequest("Bad Request");
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + user.Id, user);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            _userModule.DeleteUser(id);
            return Ok("Record is deleted ");
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateUser(int id)
        {
            _userModule.UpdateUser(id);
            return Ok("Record is Updated ");
        }
    }
}
