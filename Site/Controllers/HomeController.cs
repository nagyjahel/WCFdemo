using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using CalculationServiceReference;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private CalculationServiceClient calculationServiceClient = new CalculationServiceClient();

        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [Route("AddTwoIntegers")]
        public JsonResult AddTwoIntegers(int a, int b)
        {
             return Json(new
             {
                 success = true,
                 msg = calculationServiceClient.AddTwoIntegersAsync(a, b)
             });
        }

        [Route("AddTwoDoubles")]
        public JsonResult AddTwoDoubles(double a, double b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.AddTwoDoublesAsync(a, b)
            });
        }

        [Route("DivideTwoDoubles")]
        public JsonResult DivideTwoDoubles(double a, double b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.DivideTwoDoublesAsync(a, b)
            });
        }

        [Route("DivideTwoIntegers")]
        public JsonResult DivideTwoIntegers(int a, int b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.DivideTwoIntegersAsync(a, b)
            });
        }


        [Route("MultiplyTwoDoubles")]
        public JsonResult MultiplyTwoDoubles(int a, int b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.MultiplyTwoDoublesAsync(a, b)
            });
        }


        [Route("MultiplyTwoIntegers")]
        public JsonResult MultiplyTwoIntegers(int a, int b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.MultiplyTwoIntegersAsync(a, b)
            });
        }

        [Route("SubstractTwoDoubles")]
        public JsonResult SubstractTwoDoubles(int a, int b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.SubstractTwoDoublesAsync(a, b)
            });
        }

        [Route("SubstractTwoIntegers")]
        public JsonResult SubstractTwoIntegers(int a, int b)
        {
            return Json(new
            {
                success = true,
                msg = calculationServiceClient.SubstractTwoIntegersAsync(a, b)
            });
        }



    }
}
