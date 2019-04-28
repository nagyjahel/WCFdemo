using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OperationServiceReference;
using Site.Models;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private OperationServiceClient operationServiceClient = new OperationServiceClient();

        public IActionResult Index()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [Route("/numbers/plus")]
        public JsonResult Add(double value1, double value2)
        {
            return Json(new
            {
                success = true,
                result = operationServiceClient.AddAsync(value1, value2).Result
             });
        }

        [Route("numbers/divide")]
        public JsonResult Divide(double value1, double value2)
        {
            return Json(new
            {
                success = true,
                result = operationServiceClient.DivideAsync(value1, value2).Result
            });
        }
        
        [Route("numbers/multiply")]
        public JsonResult Multiply(double value1, double value2)
        {
            return Json(new
            {
                success = true,
                result = operationServiceClient.MultiplyAsync(value1, value2).Result
            });
        }

        [Route("numbers/minus")]
        public JsonResult Substract(double value1, double value2)
        {
            return Json(new
            {
                success = true,
                result = operationServiceClient.SubstractAsync(value1, value2).Result
            });
        }

    



    }
}
