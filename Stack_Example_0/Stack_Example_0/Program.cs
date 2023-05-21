using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack(10);

            S.push(13);
            S.push(93);
            S.push(65);
            S.push(28);
            S.push(71);
            S.push(92);
            S.push(11);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stack Is : ");
            S.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            S.pop();
            S.pop();
            S.push(65);
            Console.WriteLine("Stack Is : ");
            S.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Top Is : ");
            int p = S.peek();
            Console.WriteLine(p);
            Console.ResetColor();
            Console.WriteLine();

            S.removeDoubles(S);
            Console.WriteLine("Stack Is : ");
            S.print();
            Console.ResetColor();
            Console.WriteLine("\n");


            //Console.ForegroundColor = ConsoleColor.Green;
            //int a = S.avg();
            //Console.WriteLine("Average Is : ");
            //Console.WriteLine(a);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
