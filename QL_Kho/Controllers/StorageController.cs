using Microsoft.AspNetCore.Mvc;
using QL_Kho.Models;
using System.Diagnostics;

namespace QL_Kho.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}
