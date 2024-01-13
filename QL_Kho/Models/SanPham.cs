using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QL_Kho.Models
{
    public class SanPham
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string tenSanPham { get; set; }
        public string maSanPham { get; set; }
        public string donViTinh { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
        public int thanhTien { get; set; }
        public SanPham()
        {


        }

    }
}
