using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheGymApp.Model;
using TheGymApp.Service;
using TheGymApp.Service.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheGymApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IZsysUserService _zsysUserService;
        public UserController(IZsysUserService zsysUserService)
        
{
            _zsysUserService = zsysUserService;
        }
        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [Route("/addnew")]
        [HttpPost]
        public async Task<IActionResult> AddNewMember([FromBody] ZSysUserDTO MemberDetails)
        {
            if (!ModelState.IsValid)
                return StatusCode(500);
            await _zsysUserService.CreateNewMember(MemberDetails);

            return Ok();

        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
         { 
            var details = await _zsysUserService.GetMemberDetails(1);
            if (details != null)
            return Ok(details);

            return NoContent();            
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewMember memberModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            return Ok();
        }



    }
}
