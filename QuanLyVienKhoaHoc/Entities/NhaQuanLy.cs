using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhaQuanLy : NhanVien
    {
        public float BacLuong { get; set; }
        public String ChucVu { get; set; }
        public int SoNgayCong { get; set; }

        public override void Nhap()
        {
            //Nhập nhân viên trước
            base.Nhap();
            //Nhập các thuộc tính còn lại của nhà quản lý
            Console.Write("Bac Luong: ");
            BacLuong = float.Parse(Console.ReadLine());
            Console.Write("Chuc Vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("So Ngày Công: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\tBậc Lương: {0}", BacLuong);
            Console.WriteLine("\tChức Vụ: {0}", ChucVu);
            Console.WriteLine("\tSố Ngày Công: {0}", SoNgayCong);
        }
    }
}
