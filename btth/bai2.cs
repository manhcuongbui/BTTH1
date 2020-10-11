using System;
using System.Collections.Generic;
using System.Text;

namespace btth1 // bài 2;
{
    class Employee
    { 
        // thành phần dữ liệu vào: id, name, yearofBirth,salaryLevel,basicSalary.
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;
        // các phương thức:getId(),getname,... dislay,setSalaryLevel,setBasicSalry. 
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getyearOfBirth()
        {
            return yearOfBirth;
        }
        public double getIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void display()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("THÔNG TIN NGƯỜI LAO ĐỘNG!");
            Console.Write("định danh:{0}\t,Tên:{1}\t,Năm sinh:{2}\t,Lương cơ bản:{3}\t,Thu nhập:{4}\t ",id,name,yearOfBirth,basicSalary, getIncome());
        }
        public double setSalaryLevel
        {
            get
            {
                return salaryLevel;
            }
            set
            {
                salaryLevel = value;
            }
        }
        public double setBasicSalary
        {
            get
            {
                return basicSalary;
            }
            set
            {
                basicSalary = value;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}

   