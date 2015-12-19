using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace aspnet_benchmark_mvc.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public async Task<string> Get()
        {
            return $"Hello world! {DateTime.UtcNow}";
        }
    }
}
