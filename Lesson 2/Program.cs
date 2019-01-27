using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        /// <summary>
        /// Задержка выполнения программы на указанное время
        /// </summary>
        /// <param name="secTime">Время задержки в секундах</param>
        public static void Sleep(int secTime)
        {
            System.Threading.Thread.Sleep(secTime * 1000);
        }

        /// <summary>
        /// Осуществляет поиск минимального значения из трех чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Вывод минимального значения</returns>
        public static double MinNumber(double a, double b, double c)
        {
            if (a<=b && a<=c)
            {
                return a;
            }
            else if (b<=c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        /// <summary>
        /// Осуществляет подсчет количества цифр в числе
        /// </summary>
        /// <param name="num">Анализируемое число</param>
        public static void ColNumber(string num)
        {
            int firstPart = 0, secondPart = 0;
            bool flag = true;
            foreach (var item in num.ToString())
            {
                if (item==','||item=='.')
                {
                    flag = false;
                    --secondPart;
                }
                if (flag==true)
                {
                    ++firstPart;
                }
                else
                {
                    ++secondPart;
                }
            }
            if (flag==false)
            {
                Console.WriteLine($"В целой части числа {firstPart} цифр, а в десятичной части {secondPart} чисел");
            }
                Console.WriteLine($"Всего в вашем числе {firstPart+secondPart} цифр.");
            

        }

        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 1: Написать метод, возвращающий минимальное из трех чисел.*/
            /*
           #region Задача 1
           //int TIMER = 2;
           double a = 0, b = 0, c = 0;
           Console.WriteLine("*********************************************************************");
           Console.WriteLine("Выполнение задания 1.");
           Console.WriteLine("Для поиска минимального числа вам нужно ввести три значения.");
           Console.Write("Введите первое число: ");
           a = Convert.ToDouble(Console.ReadLine());
           Console.Write("Введите второе число: ");
           b = Convert.ToDouble(Console.ReadLine());
           Console.Write("Введите третье число: ");
           c = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine($"Минимальное число: {MinNumber(a, b, c)}");
           Console.WriteLine("*********************************************************************");
           //Sleep(TIMER);
           #endregion
           */
            #region Задаиние 2
            /*Задание 2: Написать метод подсчета количества цифр числа.*//*
            string number = "";
            Console.WriteLine("Выполнение задания 2.");
            Console.WriteLine("В вашем числе будет произведен подсчет количества цифр. ");
            Console.Write("Введите ваше число: ");
            number = Console.ReadLine();
            ColNumber(number);
            Console.WriteLine("*********************************************************************");
            Console.ReadKey();
            #endregion
            */
            
            #region Задание 3:
            /*Задание 3: С клавиатуры вводятся числа, пока не будет введен 0. 
             * Подсчитать сумму всех нечетных положительных чисел.*/


            #endregion

}
}
}
