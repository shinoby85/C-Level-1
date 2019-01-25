using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 4: Написать программу обмена значениями двух переменных.
             * а) с использованием третьей переменной;
             * б) *без использования третьей переменной.
             */

            int a=0, b=0, c;
            bool err = false;
            try
            {
                Console.Write("Введите значение переменной А: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение переменной B: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("Введенное значение нельзя преобразовать к типу Int32, " +
                    "либо произошел выход за пределы допустимого диапазона");
                err = true;
            }
            if (err == false)
            {
                Console.WriteLine("**********************************************************************");
                Console.WriteLine($"Значения переменных после выполнения первой части задания:");
                c = a;
                a = b;
                b = c;
                Console.WriteLine($"A={a}\tB={b}");
                Console.WriteLine("**********************************************************************");
                Console.WriteLine($"Значения переменных после выполнения второй части задания:");
                a += b;
                b = a - b;
                a -= b;
                Console.WriteLine($"A={a}\tB={b}");
                Console.WriteLine("**********************************************************************");
            }
            Console.ReadKey();

        }
    }
}
