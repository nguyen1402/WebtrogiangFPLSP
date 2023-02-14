using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;

namespace FPLSP.GoogleController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpGet]
        [Route("google-login")]
        public async Task<IActionResult> Google()
        {

            var properties = new AuthenticationProperties
            {
                RedirectUri = "/adminlogin",

            };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }
    }
}
