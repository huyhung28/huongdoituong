using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class nguoi
    {
        public int SDT {  get; set; }
        public nguoi() { 
        
        }
        public nguoi(int SDT)
        {
            SDT = SDT;
        }
        public void nhap()
        {
            Console.Write("nhap so dien thoai: ");
            SDT=Convert.ToInt32(Console.ReadLine());

        }
        public void xuat()
        {
            Console.WriteLine("so dien thoai la: "+SDT);
           
        }

    }
}
