using GestaoInvestimentos.Domain.Auth;
using GestaoInvestimentos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestaoInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUsuarioService _authenticationService;

        public AuthenticationController(IUsuarioService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Post([FromBody] UserAuth model)
        {
            try
            {
                var response = _authenticationService.Authenticate(model);

                if (response == null)
                    return BadRequest(new { message = "Username or password is incorrect" });

                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
