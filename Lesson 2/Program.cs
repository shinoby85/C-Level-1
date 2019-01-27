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

        /// <summary>
        /// Возвращает сумму цифр числа
        /// </summary>
        /// <param name="num">Передаваемое число</param>
        /// <returns>Сумма цифр числа</returns>
        public static int sumNumber(int num)
        {
            int sum = 0;
            while (num!=0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
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
            /*
           string login, pass;
           int attempt = 0;
           bool flag = false;
           ConsoleKeyInfo key;
           Console.WriteLine("Выполнение задания 4.");
           Console.WriteLine("Программа выполняет проверку логина и пароля.");
           Sleep(5);
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
           */
            #endregion

            #region Задание 5
            /* Задание 5: а) Написать программу, которая запрашивает массу и рост человека, 
             * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
             * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. */
            /*
           double growth = 0, weight = 0;
           double normWeight = 0;
           double imt = 0; //индекс массы тела
           Console.WriteLine("*********************************************************************");
           Console.WriteLine("Выполнение задания 5.");
           Console.WriteLine("Программа подсчитывает индекс массы тела.");
           Console.Write("Укажите свой рост (см): ");
           growth = Convert.ToDouble(Console.ReadLine());
           Console.Write("Укажите свой вес (кг): ");
           weight = Convert.ToDouble(Console.ReadLine());
           //Вычисление индекса массы тела с выводом результатов
           imt = weight / (Math.Pow(growth / 100, 2));
           Console.WriteLine($"Индекс массы вашего тела равен {imt:0.00}");
           if (imt>25)
           {
               normWeight = 25 * (Math.Pow(growth / 100, 2));
               Console.WriteLine($"Ваш вес превышает норму, вам следует похудеть на {(weight-normWeight):0.0} кг.");
           }
           else if (imt<20)
           {
               normWeight = 20 * (Math.Pow(growth / 100, 2));
               Console.WriteLine($"Ваш вес ниже нормы, вам нужно набрать {(normWeight-weight):0.0} кг.");
           }
           else
           {
               Console.WriteLine("Ваш вес в норме! Так держать...");
           }
           Console.WriteLine("*********************************************************************");
           Console.ReadKey();
           */
            #endregion

            #region Задание 6

            /* Задание 6: *Написать программу подсчета количества «Хороших» чисел в диапазоне 
             * от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
             * Реализовать подсчет времени выполнения программы, используя структуру DateTime.*/
             /*
            DateTime start = DateTime.Now;
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Выполнение задания 6.");
            Console.WriteLine("Программа подсчета количества хороших чисел.");
            int inexGoodNumber = 0; //Счетчик количества хороших чисел
            for (int i = 1; i < 1000000000; i++)
            {
                if (i%sumNumber(i)==0)
                {
                    inexGoodNumber++;
                }

            }
            Console.WriteLine($"В интервале 1-1 000 000 000 существует {inexGoodNumber} хороших чисел.");
            Console.WriteLine($"На работу программы потрачено времени: {DateTime.Now-start}");
            Console.WriteLine("*********************************************************************");
            Console.ReadKey();
            */
            #endregion




        }


    }
}
