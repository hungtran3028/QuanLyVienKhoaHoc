using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhaKhoaHoc : NhaQuanLy
    {   
        public int SoBaiBao { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số Bài Báo: ");
            SoBaiBao = int.Parse(Console.ReadLine());

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\tSố Bài Báo: {0}", SoBaiBao);
            
        }
    }
}
