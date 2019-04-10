using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IService;

namespace AutoFacTest.Controllers
{
    public class DefaultController : Controller
    {

        public readonly ITestService _testService;

        public DefaultController(ITestService testService )
        {
            _testService = testService;
        }
        public IActionResult Index()
        {
            ViewBag.date = _testService.GetList("Name");
            return View();
        }
    }
}