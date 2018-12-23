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
            _zsysUserService.CreateNewMember(new ZSysUserDTO { DOB = memberModel.DateOfBirth, Email = memberModel.EmailAddress, Notes = memberModel.Notes });

            return Ok();
        }

    }
}
