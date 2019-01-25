using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        /// <summary>
        /// Вывод строки на консоль с указанием позиции вывода
        /// </summary>
        /// <param name="ms">Выводимая строка</param>
        /// <param name="x">Отступ слева</param>
        /// <param name="y">Отступ сверху</param>
        public static void Print(string ms,int x, int y)
        {
            //Определение длины строки для позиционирования в середине экрана
            int m = ms.Length;
            Console.SetCursorPosition(x-m/2, y);
            Console.WriteLine(ms);
        }
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 5: 
             * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
             * б) Сделать задание, только вывод организуйте в центре экрана
             * в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
             */

            string str = "Понкратьев Евгений, г. Могилев, РБ";
            Console.Write("Введите строку для вывода либо нажмите ВВОД для использования значения по умолчанию: ");
            string strUser = "";
            strUser= Console.ReadLine();
            Console.Clear();
            if (strUser=="") Print(str, Console.WindowWidth / 2, Console.WindowHeight / 2);
            else  Print(strUser, Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.ReadKey();


        }
    }
}
