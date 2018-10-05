using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KendoUIDemo.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KendoUIDemo.Controllers
{
    public class BookStoreController : Controller
    {
        private IBookData _bookData;

        public BookStoreController(IBookData bookData)
        {
            _bookData = bookData;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books_Read()
        {
            var data = _bookData.GetAll();
            return Json(data);
        }
    }
}
