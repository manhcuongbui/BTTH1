using System;
using System.Collections.Generic;
using System.Text;
namespace btth1 // bài 1.
{

    class Diem
    {
        /* phương thức khởi tạo không tham số
         phương thức khởi tạo 2 tham số.
        */
        private double x;
        private double y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            // phương thức "nhap"
            Console.WriteLine("xin mời nhập tọa độ điểm:");
            Console.WriteLine(" x=");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(" y=");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            // phương thức "hienthi".
            Console.WriteLine("({0},{1})", x, y);
        }
        public double KhoangCach()
        {
            // phương thức" KHOANG CACH"
            return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
        }
        static void Main(string[] args)
        {
            Diem t = new Diem();
            t.Nhap();
            t.Hien();
            t.KhoangCach();
            Console.ReadKey();
        }
    }
}


