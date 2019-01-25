using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 1: Написать программу «Анкета». Последовательно задаются вопросы 
             * (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
             * а) используя склеивание;
             * б) используя форматированный вывод;
             * в) *используя вывод со знаком $.
             * 
             * Задание 2: Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
             * по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
             */


            //Объявление переменных с присвоением им начальных значений
            string name="", surname="";
            int age=0;
            double growth = 0, weight = 0;
            double imt = 0; //индекс массы тела

            //Инициализация переменных с клавиатуры
            Console.Write("Как ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            surname = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите свой рост (см): ");
            growth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите свой вес (кг): ");
            weight= Convert.ToDouble(Console.ReadLine());

            //Вывод полученных данных на консоль
            Console.Clear();
            Console.WriteLine($"Вас зовут: {surname} {name}.\n" +
                $"Вам: {age} лет.\nВаши данные: {growth:0.00}см. - рост и {weight:0.00}кг. - ваш вес.");

            //Вычисление индекса массы тела с выводом результатов
            imt = weight / (Math.Pow(weight/100, 2));
            Console.WriteLine($"Ваш индекс массы тела: {imt:0.00}");
            Console.WriteLine("Нажмите любую кнопку для выхода из приложения...");
            Console.ReadKey();
        }

       
    }
}
