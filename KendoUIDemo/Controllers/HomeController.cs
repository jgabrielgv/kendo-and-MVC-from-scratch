using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIDemo.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KendoUIDemo.Controllers
{
    public class HomeController : Controller
    {
        private IProductData _productData;

        public HomeController(IProductData productData)
        {
            _productData = productData;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            ViewBag.Products = _productData.GetAll();
            return View();
        }

        public IActionResult ProductsAjax()
        {
            return View();
        }

        public IActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            DataSourceResult result = _productData.GetAll().AsQueryable().ToDataSourceResult(request);
            return Json(result);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
