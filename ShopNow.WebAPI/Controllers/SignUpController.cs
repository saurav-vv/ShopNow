using Microsoft.AspNetCore.Mvc;
using ShopNow.BusinessLayer.Interfaces;
using ShopNow.Common.DataModel;
using System.Threading.Tasks;

namespace ShopNow.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly ISignUpRepository _signUpRepository;

        public SignUpController(ISignUpRepository signUpRepository)
        {
            _signUpRepository = signUpRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _signUpRepository.GetAllUsersAsync();
            return Ok(result);  
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsersById([FromRoute] int id)
        {
            var result = await _signUpRepository.GetUserByID(id);
            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewUser([FromBody] SignUpModel signUpModel)
        {
          var userID = await _signUpRepository.addNewUser(signUpModel);
            return CreatedAtAction(nameof(GetUsersById), new {id = userID, controller = "SignUp"}, userID);
        }
    }
}
