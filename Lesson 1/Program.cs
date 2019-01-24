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
