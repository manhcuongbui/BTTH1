using System;
using System.Collections.Generic;
using System.Text;

namespace btt1 // bai3.
{
    class Stack
    {
        /* khởi tạo không tham số
         khởi tạo một tham số
         */
        private int top;
        private int[] s;

        public Stack()
        {
            top = -1;
            s = new int[20];
        }

        public Stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        // kiểm tra stack rỗng.
        public bool isEmpty()
        {
            return top == -1;
        }
        // kiểm tra stack đầy ko.
        public bool isFull()
        {
            return top == s.Length - 1;
        }
        // thêm vào một phần tử.
        public void Push(int x)
        {
            if (isFull())
                Console.WriteLine("Stack day");
            else
                s[++top] = x;
        }
        // lấy ra một phần tử.
        public int Pop()
        {
            if (isEmpty())
                throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
        static void Main3(string[] args)
        {


        }
    }
} 
