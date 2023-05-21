using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Example_0
{
    class Stack
    {
        public int[] s;
        public int top;
        public int max;
        public Stack(int size)
        {
            s = new int[size];
            top = -1;
            max = size;
        }
        public void print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write(s[i] + " . ");
                }
            }
        }
        public void push(int data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Is Full !");
                return;
            }
            else
            {
                s[++top] = data;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
            }
            else
            {
                Console.WriteLine($"{s[top]} Is Deleted...");
                return s[top--];
            }
        }

        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
            }
            else
            {
                return s[top];
            }
        }
        public int avg()
        {
            int sum = 0;
            int c = 0;
            int avg;
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    sum += s[i];
                    c++;
                }
                Console.WriteLine($"Sum Is : {sum}");
                Console.WriteLine($"Count Is : {c}");
                avg = sum / c;
                return avg;
            }
        }
    }
}
