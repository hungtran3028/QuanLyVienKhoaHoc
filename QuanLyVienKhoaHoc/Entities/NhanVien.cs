using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string BangCap { get; set; }


        public virtual void Nhap()
        {
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nam Sinh: ");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Bang Cap: ");
            BangCap = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\tHọ Tên: {0}", HoTen);
            Console.WriteLine("\tNăm Sinh: {0}", NamSinh);
            Console.WriteLine("\tBằng Cấp: {0}", BangCap);
        }
    }
}
