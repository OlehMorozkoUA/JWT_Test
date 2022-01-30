using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Authorize]
        [Route("getlogin")]
        public string GetLogin()
            => $"Your login is {User.Identity.Name}";

        [Authorize(Roles = "admin")]
        [Route("getrole")]
        public string GetRole()
            => $"Your role is admin";
    }
}
