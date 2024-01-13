using Microsoft.AspNetCore.Mvc;
using QL_Kho.Models;
using System.Diagnostics;

namespace QL_Kho.Controllers
{
    public class StorageController : Controller
    {
        public IActionResult QuanLyKhoHang()
        {
            return View();
        }
        public IActionResult PhieuNhapKho()
        {
            return View();
        }
       
        public IActionResult PhieuXuatKho()
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
