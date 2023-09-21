using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class hocsinh : nguoi
    {
        private int MaHS;
        string tenHS;
        int namsinh;
        string diachi;
        double diemtoan, diemvan, diemanh, DTB;
        public hocsinh()
        {

        }
        public hocsinh(int ma, string ten, int ns, string diachi)
        {
            MaHS = ma;
            this.tenHS = ten;
            this.namsinh = ns;
            this.diachi = diachi;
        }
        
        public void nhapHS()
        {
            Console.Write("nhap ma HS: ");
            MaHS=Convert.ToInt16(Console.ReadLine());
            Console.Write("nhap ten hoc sinh: ");
            tenHS= Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
            nhap();
            Console.Write("Nhap diem toan: ");
            diemtoan=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van:");
            diemvan=Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh");
            diemanh = Convert.ToDouble(Console.ReadLine());
        }
       public Double TinhDTB()
        {
            DTB = Math.Round((diemtoan + diemanh + diemvan) / 3, 1);
            return DTB;
        }
        public void xuatHS()
        {
            Console.WriteLine("ma hoc sinh la " + MaHS);
            Console.WriteLine("ten hoc sinh la: " + tenHS);
            Console.WriteLine("nam sinh hoc sinh la: " + namsinh);
            Console.WriteLine("dia chi la" + diachi);
            xuat();
            Console.WriteLine("diem trung binh la: " + DTB);
               
        }
    }
}
