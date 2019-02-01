using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    struct Complex
    {
        public double im;
        public double re;
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат сложения</returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат умножения</returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary>
        /// Разность комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат деления</returns>
        public Complex Razn(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        /// <summary>
        /// Деление комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат деления комплексных чисел</returns>
        public Complex Division (Complex x)
        {
            Complex y;
            y.re = (re * x.re + im * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            y.im=(x.re*im-re*x.im)/ (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            return y;
        }



        public string ToString(){
            return re + "+" + im + "i";
        }
    }

    class ComplexCL
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public ComplexCL Plus(ComplexCL x2)
        {
            ComplexCL x3 = new ComplexCL();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат умножения</returns>
        public ComplexCL Multi(ComplexCL x)
        {
            ComplexCL y=new ComplexCL();
            y.im = this.re * x.im + this.im * x.re;
            y.re = this.re * x.re - this.im * x.im;
            return y;
        }
        /// <summary>
        /// Разность комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат деления</returns>
        public ComplexCL Razn(ComplexCL x)
        {
            ComplexCL y=new ComplexCL();
            y.re = this.re - x.re;
            y.im = this.im - x.im;
            return y;
        }
        public ComplexCL()
        {
            im = 0;
            re = 0;
        }

        // Конструктор, в котором задаем поля.    
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public ComplexCL(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }

        /// <summary>
        /// Деление комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Результат деления комплексных чисел</returns>
        public ComplexCL Division(ComplexCL x)
        {
            ComplexCL y=new ComplexCL ();
            y.re = (this.re * x.re + this.im * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            y.im = (x.re * this.im - this.re * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            return y;
        }

        public string ToString()
        {
            return this.re + "+" + this.im + "i";
        }
    }



    class Program
    {

        /// <summary>
        /// Выполняет подсчет количества нечетных чисел и их суммы
        /// </summary>
        /// <param name="colOddNumber">Передача начального значения счетчика</param>
        /// <returns>Возврат суммы нечетных чисел</returns>
        public static List<int> SumNumber(ref int colOddNumber, ref int sum)
        {
            List<int> mas=new List<int>();
            int i = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Введите число: ");
                if (Int32.TryParse(Console.ReadLine(), out int num) && num > 0)
                {
                    if (num % 2 != 0)
                    {
                        mas.Add(num);
                        sum += num;
                        colOddNumber++;
                        i++;
                    }
                }
                else if (num == 0) break; 
                else
                {
                    Console.WriteLine("Введенные данные не корректны. Повторите ввод.");
                }
            }

            return mas;
        }

        static void Main(string[] args)
        {

            #region Задание 1
            /*Понкратьев Евгений
             * Задание 1: а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
             * Продемонстрировать работу структуры.
             * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
             * в) Добавить диалог с использованием switch демонстрирующий работу класса.*/
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Razn(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Division(complex2);
            Console.WriteLine(result.ToString());

            // Создали объект и сохранили ссылку на него в complex1.
            ComplexCL complex3 = new ComplexCL(1,1);
            // Описали объект и создали его.
            ComplexCL complex4 = new ComplexCL(2, 2);
            Console.ReadKey();
            
            int ind;
            do
            {
                Console.Clear();
                Console.WriteLine("Выиерите операцию над комплексными числами.");
                Console.WriteLine("1. Сложение комплексных чисел.");
                Console.WriteLine("2. Вычитание комплексных чисел.");
                Console.WriteLine("3. Умножение комплексных чисел.");
                Console.WriteLine("4. Деление комплексных чисел.");
                Console.Write("Сделайте выбор: ");
                ind = Convert.ToInt32(Console.ReadLine());
                switch (ind)
                {
                    case 1: Console.WriteLine(complex3.Plus(complex4).ToString()); break;
                    case 2: Console.WriteLine(complex3.Razn(complex4).ToString()); break;
                    case 3: Console.WriteLine(complex3.Multi(complex4).ToString()); break;
                    case 4: Console.WriteLine(complex3.Division(complex4).ToString()); break;

                    default:Console.WriteLine("Введено не допустимое значение. Повторите выбор.");                        
                        break;
                }
                Console.ReadKey();
            }
            while (ind < 1 || ind > 4);
            
            #endregion

            #region Задание 2
            /* Задание 2: а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
             * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, 
             * используя tryParse;
             * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
             * При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/

            Console.WriteLine("Программа выполняет подсчет суммы положительных не четных чисел.");
            Console.WriteLine("Введенная строка приравнивается к нулю.");
            Console.ReadKey();
            int schet = 0, sum=0;
            List<int> mas= SumNumber(ref schet, ref sum);
            Console.WriteLine($"Сумма нечетных чисел равна: {sum}");
            Console.WriteLine($"Всего введено {schet} чисел.");
            Console.Write("Список чисел: ");
            foreach (var item in mas)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
            




            #endregion

            #region Задание 3
            /* Задание 3: *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
             * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
             * Написать программу, демонстрирующую все разработанные элементы класса. 
             * ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
             * ArgumentException("Знаменатель не может быть равен 0");
             * Добавить упрощение дробей.*/
            Console.WriteLine("Задание 3: Вычисление значений дробей.....");
            Console.ReadKey();
            Application.EnableVisualStyles();
            Application.Run(new dataForm());


            #endregion







        }
    }
}
