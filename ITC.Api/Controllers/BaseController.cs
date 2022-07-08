using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // Ping: api/<BaseController>
        [HttpGet]
        public string Ping()
        {
            return DateTime.Now.ToString();
        }
    }
}
