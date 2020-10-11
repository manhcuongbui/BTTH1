using System;
using System.Collections.Generic;
using System.Text;

namespace btth // bài 9: xây dựng một lớp vecto và hiện các phép toán trên vecto gồm có tổng,hiệu,tích.
{
    using System;
    class Vecto
    {
        // thuộc tính
        private int n;
        private int[] v;
        // phương thức: khởi tạo, sao chép.
        public Vecto()
        {
            n = 2;
            v = new int[2];
        }
        public Vecto(int n)
        {
            this.n = n;
            v = new int[n];
        }
        public void Nhap()
        {
            // nhập hai vecto từ bàn phím
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin của vecto");
            for (int i = 0; i < n; ++i)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("THÔNG TIN CỦA VECTO:");
            for (int i = 0; i < n; ++i)
                Console.Write("{0},", i);
        }
        public Vecto Tong(Vecto t2)
        {
            // tính tổng 2 vecto.
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.v[i] = this.v[i] + t2.v[i];
                return t;
            }
            else return null;
        }
        public Vecto Hieu(Vecto t2)
        {
            // tính hiệu 2 vecto.
            if (this.n == t2.n)
            {
                Vecto t = new Vecto(this.n);
                for (int i = 0; i < n; ++i)
                    t.v[i] = this.v[i] - t2.v[i];
                return t;
            }
            else return null;
        }
    }
    class TEST
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin vecto thứ 1 :");
            Vecto t1 = new Vecto(5); t1.Nhap();
            Console.WriteLine("Nhập thông tin cho vecto thứ 2 :");
            Vecto t2 = new Vecto(5); t2.Nhap();
            Console.WriteLine("Tổng hai vecto:");
            Vecto t3 = t1.Tong(t2);
            Console.WriteLine("Hiệu hai vecto:");
            Vecto t4 = t1.Hieu(t2);
            if (t3 == null)
                if(t4==null)
                Console.WriteLine("ERRORS!");
            else
            {
                Console.WriteLine("Tổng hai vecto:");
                t3.Hien();
                    Console.WriteLine("Hiệu hai vecto:");
                    t4.Hien();
            }
            Console.ReadKey();
        }
    }






}
