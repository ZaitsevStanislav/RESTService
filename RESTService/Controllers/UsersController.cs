using Microsoft.AspNetCore.Mvc;
using RESTService.Models;
using RESTService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _dataService;

        public UsersController(IUserService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _dataService.GetUsers();
        }

        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            _dataService.AddUser(user);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            try
            {
                _dataService.UpdateUser(user);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] User user)
        {
            try
            {
                _dataService.DeleteUser(user.Id);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("GetSomeString")]
        public string GetSomeString()
        {
            return "SomeString";
        }
    }
}
