using System;

namespace huongdoituong
{
    internal class Program
    {
        static void Main(string[] args)
        {

            hocsinh hocsinh = new hocsinh();
            //hocsinh hocsinh2= new hocsinh(10,"yen",2003,"thai nguyen");
            Console.WriteLine("nhap so luong sinh vien: ");
            int n = Convert.ToInt16(Console.ReadLine());
            hocsinh[] dssv = new hocsinh[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("nhap thong tin sinh vien thu: " + (i + 1));


                dssv[i] = new hocsinh();
                dssv[i].nhapHS();
                dssv[i].TinhDTB();

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("thong tin sinh vien thu " + (i + 1));
                dssv[i].xuatHS();

            }

            Console.Read();


        }
    }
}
