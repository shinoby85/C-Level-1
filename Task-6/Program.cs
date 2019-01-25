using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class TrainingClass
    {
        /// <summary>
        /// Вывод строки на консоль с указанием позиции вывода
        /// </summary>
        /// <param name="ms">Выводимая строка</param>
        /// <param name="x">Отступ слева</param>
        /// <param name="y">Отступ сверху</param>
        public static void Print(string ms, int x, int y)
        {
            //Определение длины строки для позиционирования в середине экрана
            int m = ms.Length;
            Console.SetCursorPosition(x - m / 2, y);
            Console.WriteLine(ms);
        }

        /// <summary>
        /// Вывод строки на консоль с указанием позиции вывода
        /// </summary>
        /// <param name="ms">Выводимая строка</param>
        /// <param name="x">Отступ слева</param>
        /// <param name="y">Отступ сверху</param>
        public static void Print(string ms, string x, string y)
        {
            int m = ms.Length;
            int a, b;
            switch (x)
            {
                case "left": a = 0;break;
                case "center": a = Console.WindowWidth/2 - m / 2;break;
                case "right": a = Console.WindowWidth - m;break;
                default: a = 0;break;
            }
            switch (y)
            {
                case "top": b = 0;break;
                case "center": b = Console.WindowHeight / 2;break;
                case "bottom": b = Console.WindowHeight;break;
                default: b = 0;break;
            }
            Console.SetCursorPosition(a, b);      
            Console.WriteLine(ms);

        }

        /// <summary>
        /// Задержка выполнения программы на указанное время
        /// </summary>
        /// <param name="secTime">Время задержки в секундах</param>
        public static void Sleep(int secTime)
        {
            System.Threading.Thread.Sleep(secTime * 1000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 6: *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
             */
            TrainingClass.Print("Hello my new class!!!", "center", "top");
            TrainingClass.Sleep(5);
        }
    }
}
