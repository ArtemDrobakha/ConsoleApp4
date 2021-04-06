using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        delegate void Link();
        static int Fact(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void F1()
        {
            double sum = 1;
            double item;
            for (int i = 2; true; i *= 2)
            {
                item = 1.0 / i;
                if (item < 0.01)
                {
                    break;
                }
                sum += item;
            }
            Console.WriteLine(sum);
        }
        static void F2()
        {
            double sum = 1;
            double item;
            for (int i = 2; true; i++)
            {
                item = 1.0 / Fact(i);
                if (item < 0.01)
                {
                    break;
                }
                sum += item;
            }
            Console.WriteLine(sum);
        }
        static void F3()
        {
            double sum = 1;
            double item;
            int a = 1;
            for (int i = 2; true; i *= 2)
            {
                item = 1.0 / i;
                if (item < 0.01)
                {
                    break;
                }
                sum += item * a;
                a = -a;
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            Link link = F1;
            link += F2;
            link += F3;
            link();

            Console.ReadKey();
        }
    }
}