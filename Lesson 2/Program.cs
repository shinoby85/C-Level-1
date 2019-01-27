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
        
        /// <summary>
        /// Выполняет подсчет количества нечетных чисел
        /// </summary>
        /// <param name="colOddNumber">Передача начального значения счетчика</param>
        /// <returns>Возврат количества нечетных чисел</returns>
        public static int NewMethod(int colOddNumber)
        {
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                if (num % 2 != 0)
                {
                    colOddNumber++;
                }
            }

            return colOddNumber;
        }

        /// <summary>
        /// Проверка корректности логина и пароля
        /// </summary>
        /// <param name="login">Передача значения логина</param>
        /// <param name="pass">Передача значения пароля</param>
        /// <returns>Результат проверки пароля</returns>
        public static bool CheckPass(string login, string pass)
        {
            if (login== "root" && pass== "GeekBrains")
            {                
                return true;
            }
            return false;
        }

        /// <summary>
        /// Вводимые с клавиатуры данные отображает ввиде *
        /// </summary>
        /// <param name="pass">Начальное значение строки</param>
        /// <returns>Возврат конечного значения</returns>
        private static ConsoleKeyInfo InputPass(ref string pass)
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey(true); //Не отображать вводимые с клавиатуры символы
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    pass += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(pass))
                    {
                        //Удаляет один символ из строки пароля
                        pass = pass.Substring(0, pass.Length - 1);
                        int cursorPosition = Console.CursorLeft;//задает позицию курсора
                        Console.SetCursorPosition(cursorPosition - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(cursorPosition - 1, Console.CursorTop);
                    }
                }
                key = Console.ReadKey(true);
            }
            Console.WriteLine();
            return key;
        }



        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 1: Написать метод, возвращающий минимальное из трех чисел.*/
            
           #region Задача 1
            /*
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
           */
           #endregion
           
            #region Задаиние 2
            /*Задание 2: Написать метод подсчета количества цифр числа.*//*
            string number = "";
            Console.WriteLine("Выполнение задания 2.");
            Console.WriteLine("В вашем числе будет произведен подсчет количества цифр. ");
            Console.Write("Введите ваше число: ");
            number = Console.ReadLine();
            ColNumber(number);
            Console.WriteLine("*********************************************************************");
            Console.ReadKey();*/
            #endregion


            #region Задание 3:
            /*Задание 3: С клавиатуры вводятся числа, пока не будет введен 0. 
             * Подсчитать сумму всех нечетных положительных чисел.*//*
            Console.WriteLine("Выполнение задания 3.");
            Console.WriteLine("Программа подсчитывает количество введенных нечетных чисел. \n" +
                "Для выхода с программы введите '0'");
            int colOddNumber = 0;
            colOddNumber = NewMethod(colOddNumber);
            Console.WriteLine($"Было введено {colOddNumber} нечетных чисел.");
            Console.WriteLine("*********************************************************************");
            Console.ReadKey();*/
            #endregion

            #region Задание 4
            /* Задание 4: Реализовать метод проверки логина и пароля. 
             * На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, 
             * если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
             * написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
             * С помощью цикла do while ограничить ввод пароля тремя попытками.*/

            string login, pass;
            int attempt = 0;
            bool flag = false;
            ConsoleKeyInfo key;
            Console.WriteLine("Выполнение задания 4.");
            Console.WriteLine("Программа выполняет проверку логина и пароля.");
            Sleep(1);
            do
            {
                login = "";
                pass="";
                Console.Clear();
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                key = InputPass(ref pass);
                flag = CheckPass(login, pass);
                attempt++;
            } while (attempt<3 && flag==false);
            if (flag==true)
            {
                Console.Clear();
                Console.WriteLine("Данные введены верно. Вход выполнен.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не верный логин или пароль. \nВыход из программы...");
            }
            Console.WriteLine("*********************************************************************");
            Console.ReadKey();

            #endregion

        }

        
    }
}
