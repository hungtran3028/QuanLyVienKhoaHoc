using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhanVienPTN : NhanVien
    {
        public double LuongTrongThang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Luong trong tháng: ");
            LuongTrongThang = double.Parse(Console.ReadLine());

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\tLương Trong Tháng: {0}", LuongTrongThang);
          
        }
    }
}
