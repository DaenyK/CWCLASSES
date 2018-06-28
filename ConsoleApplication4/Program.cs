using ConsoleApplication4.module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("введите номер задания: ");
            //int nz = 0;

            //labTask1();
            //labTask2();

            //string h = "";
            //t1(out h);
            //Console.WriteLine(h);


            //int u = 65;
            //Console.WriteLine(u);
            //t2(ref u);
            //Console.WriteLine(u);

            //t3(5, 5, 5, 5, 5, 2, 21, 54, 54);


            ServiceRequest sr = new ServiceRequest();
            sr.GetRequestData().getInfo();

        }
        static void labTask1()
        {
            Console.Write("введите первое число(положительное): ");
            int y = 0;
            if (!Int32.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("введите корректное число: ");

            Console.Write("введите второе число(положительное): ");
            int x = 0;
            if (!Int32.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("введите корректное число: ");

            Console.WriteLine("результат: {0}", (y + x));
        }
        static void labTask2()
        {
            Console.Write("введите  число(положительное): ");
            string y = Console.ReadLine();
            var strAr = y.ToArray();

        }

        static void t1(out string mess)
        {
            mess = "hello";
        }

        static void t2(ref int num)
        {
            num = 4;
        }
        static void t3(params int[] p)
        {
            Console.WriteLine(p.Length);
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i]);

            }

        }
    }
}
