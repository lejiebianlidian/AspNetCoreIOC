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
        //构造函数注入
        /*public readonly ITestService _testService;

        public DefaultController(ITestService testService )
        {
            _testService = testService;
        }
        */
        //属性注入
        public ITestService _testService { get; set; }

        public IActionResult Index()
        {
            ViewBag.date = _testService.GetList("Name");
            return View();
        }
    }
}