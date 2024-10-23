
using IdentityandDataProtection.Dtos;
using IdentityandDataProtection.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAndDataProduction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<UserEntity> _userManager;

        public UserController(UserManager<UserEntity> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] IdentityandDataProtectionDtos model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new UserEntity { Email = model.Email };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
                return Ok();

            return BadRequest(result);
        }
    }
}