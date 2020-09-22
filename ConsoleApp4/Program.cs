using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 1");

            int A;
            int B;
            int R;
            Console.WriteLine("Введите число А");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            B = int.Parse(Console.ReadLine());
            int num = 1;


            Console.WriteLine("1- сложение");
            R = A + B;
            Console.WriteLine("сложение = " + R);


            Console.WriteLine("2- вычитание");
            R = A - B;
            Console.WriteLine("вычитание = " + R);


            Console.WriteLine("3- умножение");
            R = A * B;
            Console.WriteLine("умножение = " + R);


            Console.WriteLine("4- деление");
            R = A / B;
            Console.WriteLine("деление = " + R);



            Console.WriteLine("ЗАДАНИЕ 2");

            int y;
            int x;
            int z;
            int d;
            int k;
            int c;
            Console.WriteLine("Введите число x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число d");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число z");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число k");
            k = int.Parse(Console.ReadLine());

            if (z < 0)
            {
                x = z * z - z;
                Console.WriteLine("y =" + (Math.Pow(Math.Sin(c * x + d * d + k * x * x), 2)));
            }
            else
            {
                x = z * z * z;
                Console.WriteLine("y =" + (Math.Pow(Math.Sin(c * x + d * d + k * x * x), 2)));
            }


            Console.WriteLine("ЗАДАНИЕ 3");

            int st1;
            int st2;
            int st3;
            Console.WriteLine("Введите первую сторону треугольника(катет)");
            st1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника(катет)");
            st2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника(гипотенуза)");
            st3 = int.Parse(Console.ReadLine());
            NewMethod(st1,st2,st3);
            Console.WriteLine("Введите первую сторону треугольника(катет)");
            st1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника(катет)");
            st2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника(гипотенуза)");
            st3 = int.Parse(Console.ReadLine());
            NewMethod(st1, st2, st3);
            Console.WriteLine("Введите первую сторону треугольника(катет)");
            st1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника(катет)");
            st2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника(гипотенуза)");
            st3 = int.Parse(Console.ReadLine());
            NewMethod(st1, st2, st3);


        }

        private static void NewMethod(int st1, int st2, int st3)
        {
           
            if (st1 != 0 && st2 != 0 && st3 != 0)
            {
                if (st3 * st3 == st1 * st1 + st2 * st2)
                {
                    Console.WriteLine("треугольник прямоугольный");

                }
                else
                {
                    

                    Console.WriteLine("угол равен = "+ Math.Sin((st1*st1 + st2*st2 - st3*st3)/2*st1*st2));

                }
            }
            else
            {
                Console.WriteLine("введите заново");
            }
        }
    }
}
