using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace LearnNLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Logger _logger;
        public HomeController()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.Info("HomeController.Get");
            return new string[] { "value1", "value2" };
        }
    }
}