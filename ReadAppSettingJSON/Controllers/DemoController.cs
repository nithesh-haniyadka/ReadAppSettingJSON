using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ReadAppSettingJSON.Controllers
{
    [Route("Demo")]
    public class DemoController : Controller
    {
        private IConfiguration configuration;

        public DemoController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            //var config1 = configuration["DefaultLevel:Error"];
            //Debug.WriteLine("Error", config1);
            //var config2 = configuration["DefaultLevel:Debug"];
            //Debug.WriteLine("Debug", config2);
            //var config3 = configuration["DefaultLevel:Warning"];
            //Debug.WriteLine("Warning", config3);
            return View();
        }
    }
}
