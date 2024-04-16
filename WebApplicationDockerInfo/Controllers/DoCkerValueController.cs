using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDockerInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoCkerValueController : ControllerBase
    {
        [HttpGet]
        public string GetValue()
        {
            return "1345678";
        }
    }
}
