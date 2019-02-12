using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_6
{
    delegate double MathFunction(double data1, double data2);
    class Program
    {

        /// <summary>
        /// Вычисление значения функции a * Math.Pow(x , 2)
        /// </summary>
        /// <param name="x">Передаваемы параметр X</param>
        /// <param name="a">Передаваемы параметр A</param>
        /// <returns></returns>
        public static double myFanc1(double x, double a)
        {
            return a * Math.Pow(x , 2);
        }
        /// <summary>
        /// Вычисление значения функции a * Math.Sin(x);
        /// </summary>
        /// <param name="x">Передаваемый параметр X</param>
        /// <param name="a">Передаваемый параметр A</param>
        /// <returns></returns>
        public static double myFanc2(double x, double a)
        {
            return a * Math.Sin(x);
        }
        /// <summary>
        /// Вычисление значения функции на промежутке от -4 до x
        /// </summary>
        /// <param name="myFanc">Передаваемая функция</param>
        /// <param name="x">Значения переменной x, т.е. до какого числа</param>
        /// <param name="a">Переменная a</param>
        public static void myTable(MathFunction myFanc,double x, double a)
        {
            Console.WriteLine("----- A ----- X ----- F(x) -----");
            for (double i = -4; i < x; i+=0.5)
            {
                Console.WriteLine("| {0,8:0.0} | {1,8:0.0} | {2,8:0.000} |", a, i, myFanc(i, a));
                
            }
            
            Console.WriteLine("---------------------------------");

        }



        static void Main(string[] args)
        {
            /*Понкратьев Евгений
            * Задание 1. Изменить программу вывода функции так, чтобы можно было передавать 
            * функции типа double (double,double). Продемонстрировать работу на функции 
            * с функцией a*x^2 и функцией a*sin(x).*/
            /*
            Console.Write("Введите значение X: ");
            double x =Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------- Результат вычисления функции a*x^2 --------------");

            myTable(myFanc1, x, a);
            Console.WriteLine("-------------- Результат вычисления функции a*sin(x) --------------");
            myTable(myFanc2, x, a);
            */
            /*Задание 2. Модифицировать программу нахождения минимума функции так, 
             * чтобы можно было передавать функцию в виде делегата.
             * а) Сделайте меню с различными функциями и предоставьте пользователю выбор, 
             * для какой функции и на каком отрезке находить минимум.
             * б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
             * в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. 
             * Пусть она возвращает минимум через параметр.*/
            double ax, bx, h;
            
            Console.Write("Введите промежуток, на котором произойдет выборка значсений: ");
            Console.Write("AX: ");
            ax=Convert.ToDouble(Console.ReadLine());
            Console.Write("BX: ");
            bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг H: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите функцию для анализа.");
            int reg = -1;
            do
            {
                Console.WriteLine(@"1. Расчет по функции x * x - 50 * x + 10");
                Console.WriteLine(@"2. Расчет по функции (2 * x + 1) / (3 * x - 1)");
                Console.WriteLine(@"3. Расчет по функции x * x - 50 * x + 10");
                Console.Write("Сделайте выбор: ");
                reg = int.Parse(Console.ReadLine());
            } while (reg<=0&&reg>=4);
            switch (reg)
            {
                case 1:
                    DoubleBinary.SaveFunc(DoubleBinary.F, ax, bx, h);
                    Console.WriteLine($"Минимальное значение: {DoubleBinary.Load()}");
                    break;
                case 2:
                    DoubleBinary.SaveFunc(DoubleBinary.F1, ax, bx, h);
                    Console.WriteLine($"Минимальное значение: {DoubleBinary.Load()}");
                    break;
                case 3:
                    DoubleBinary.SaveFunc(DoubleBinary.F2, ax, bx, h);
                    Console.WriteLine($"Минимальное значение: {DoubleBinary.Load()}");
                    break;
                case 4:

                    break;
                
            }






            //SaveFunc("data.bin", -100, 100, 0.5);
            //Console.WriteLine(Load("data.bin"));
            //Console.ReadKey();







            Console.ReadKey();
        }
    }
}
