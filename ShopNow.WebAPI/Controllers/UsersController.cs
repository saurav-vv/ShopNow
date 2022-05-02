using Microsoft.AspNetCore.Mvc;
using ShopNow.BusinessLayer.Interfaces;
using System.Threading.Tasks;

namespace ShopNow.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _user;            
        public UsersController(IUserRepository user)
        {
            _user = user;
        }

        [HttpGet("")]
        public async Task<IActionResult> getAllUsersCat()
        {
            var usersCat =await _user.getAllUsersCatAsync();
            return Ok(usersCat);
        }
    }
}
