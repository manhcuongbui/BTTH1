using System;
using System.Collections.Generic;
using System.Text;

namespace btth1 //bai4;
{       
    class SoPhuc
        {
        // thuôc tính thực, ảo.
            private double thuc, ao;
            public SoPhuc()
            {
                thuc = 0;
                ao = 0;
            }

            public SoPhuc(double thuc, double ao)
            {
                this.thuc = thuc;
                this.ao = ao;
            }

            public SoPhuc(SoPhuc t2)
            {
                this.thuc = t2.thuc;
                this.ao = t2.ao;
            }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("xin mời nhập phần thực:"); thuc = double.Parse(Console.ReadLine());
            Console.Write("Xin mời nhập phần ảo :"); ao = double.Parse(Console.ReadLine());
        }


            public void Hienthi()
            {
                string kq = thuc + (ao > 0 ? "+" : "") + ao + "* i";
                Console.WriteLine(kq);
            }

            public static SoPhuc operator +(SoPhuc t1, SoPhuc t2)
            {
                SoPhuc tmp = new SoPhuc();
                tmp.thuc = t1.thuc + t2.thuc;
                tmp.ao = t1.ao + t2.ao;

                return tmp;
            }

            public SoPhuc Tong(SoPhuc t2)
            {
                SoPhuc tmp = new SoPhuc();
                tmp.thuc = this.thuc + t2.thuc;
                tmp.ao = this.ao + t2.ao;

                return tmp;
            }

            public SoPhuc Hieu(SoPhuc t2)
            {
                SoPhuc tmp = new SoPhuc();
                tmp.thuc = this.thuc - t2.thuc;
                tmp.ao = this.ao - t2.ao;

                return tmp;
            }

        // test thử.
        /*static void Main4(string[] args)
         {
            SoPhuc t1 = new SoPhuc(3, 6);
            SoPhuc t2 = new SoPhuc(t1);
            Console.WriteLine("So phuc thu nhat"); t1.Hienthi();
            Console.WriteLine("So phuc thu hai"); t2.Hienthi();
            SoPhuc t3 = t1.Tong(t2);
            SoPhuc t4 = t1.Hieu(t2);
            Console.WriteLine(" Số phức tổng:"); t3.Hienthi();
            Console.WriteLine("số phức hiệu: "); t4.Hienthi();
            Console.ReadKey();
        }*/


    }
    
}

