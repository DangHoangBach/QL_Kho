using Microsoft.AspNetCore.Mvc;
using QL_Kho.Models;
using System.Diagnostics;

namespace QL_Kho.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult NhapKho()
        {
            return View();
        }
        public IActionResult XuatKho()
        {
            return View();
        }
        public IActionResult DanhMucSanPham()
        {
            return View();
        }
        public IActionResult DanhMucKhachHang()
        {
            return View();
        }
        public IActionResult KiemKe()
        {
            return View();
        }
    }
}
