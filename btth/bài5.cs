using System;
using System.Collections.Generic;
using System.Text;

namespace btth1 // bai5: xây dựng lớp ma trận: khởi tạo, print,nhập,cộng,hiệu,đoiau,chuyenvi,tich,tuongthic,matranvuong.
{
    class matran
    {
        private int sh, sc;
        private int[,] A;
        public matran()
        {
            sh = sc = 2;
            A = new int[sh, sc];

        }
        public matran(int sh, int sc)
        {
            this.sh = sh;
            this.sc = sc;
            A = new int[sh, sc];
        }
        public matran(matran t2)

        {
            this.sh = t2.sc;
            this.sc = t2.sh;
            this.A = new int[sh, sc];
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; i++)
                    this.A[i, j] = t2.A[i, j];


        }
        public void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" Nhập thông tin cho các phần tử ma trận");
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; i++)
                {
                    Console.WriteLine("a{0},b{1}", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());

                }

        }
        public void print()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CÁC PHẦN TỬ CỦA MA TRẬN LÀ:");
            for (int i = 0; i < sh; i++)
            {
                for (int j = 0; j < sc; j++)
                    Console.WriteLine("MATRAN{0}", A[i, j]);
                Console.WriteLine();

            }
        }
        public matran Tong(matran t2)
        {
            // TÍNH TỔNG
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                matran t = new matran(this.sh, this.sc);
                for (int i = 0; i < t.sh; i++)
                    for (int j = 0; j < t.sc; j++)
                        t.A[i, j] = this.A[i, j] + t2.A[i, j];
                return t;
            }
            else return null;
        }
        public matran Hieu(matran t2)
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                matran t = new matran(this.sh, this.sc);
                for (int i = 0; i < t.sh; i++)
                    for (int j = 0; j < t.sc; j++)
                        t.A[i, j] = this.A[i, j] - t2.A[i, j];
                return t;
            }
            else return null;
        }
        ////public matran chuyenvi(matran t2)
        ////{ 
            
        ////}
        //public matran doidau(matran t2)
        //{

        //}
        //public matran tich(matran t2)
        //{

        //}
        //public matran tuongthich(matran t2)
        //{

        //}
        //public matran Matranvuong(matran t2)
        //{

        //}
    }
    class test
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin cho ma trận thứ nhất:");
            matran t1 = new matran(2, 3);
            t1.nhap();
            Console.WriteLine("Nhập thông tin cho ma trận thứ 2:");
            matran t2 = new matran(t1);
            matran t3 = t1.Tong(t2);
            if (t3 == null)
                Console.WriteLine("Hai ma trận không cùng số hàng số cột không tính được tổng!");
            else
            {
                Console.WriteLine("Thông tin của ma trận tổng :");
                t3.print();
            }
            matran t4 = t1.Hieu(t2);
            if (t4 == null)
                Console.WriteLine("không tính được!");
            t4.print();
            Console.ReadKey();
        }
    }
}
