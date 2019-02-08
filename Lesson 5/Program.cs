using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 1. Создать программу, которая будет проверять корректность ввода логина. 
             * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского 
             * алфавита или цифры, при этом цифра не может быть первой:
             * а) без использования регулярных выражений;
             * б) с использованием регулярных выражений.*/
            Console.Write("Введите логин: ");
            MyClass z1Data = new MyClass(Console.ReadLine().ToString());
            if (z1Data.CheckRegular)
            {
                Console.WriteLine("Совпадение с регулярным выражением. Логин подходит.");
            }
            else
            {
                Console.WriteLine("Данные не совпадают с регулярным выражением.");
            }
            if (z1Data.CheckString)
            {
                Console.WriteLine("Совпадение данных при ручном анализе. Логин подходит.");
            }
            else
            {
                Console.WriteLine("Данные не совпали при ручном анализе.");
            }
            Console.ReadKey();
            /*Задание 2: Разработать класс Message, содержащий следующие статические методы для обработки текста:
             * а) Вывести только те слова сообщения, которые содержат не более n букв.
             * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
             * в) Найти самое длинное слово сообщения.
             * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
             * Продемонстрируйте работу программы на текстовом файле с вашей программой.*/
            Console.Clear();
            Console.Write("Введите текст для анализа: ");
            Message dataText =new Message(Console.ReadLine().ToString());
            Console.Write("Введите длину слова: ");
            int num = int.Parse(Console.ReadLine());
            dataText.OutpuData(num);
            Console.Write("Введите символ разделители: ");
            dataText.DeleteWord(Convert.ToChar(Console.ReadLine()));
            dataText.ReadFile("freeText.txt");
            Console.WriteLine($"Максимальное слово в строке: {dataText.MaxWord}");
            
            Console.ReadKey();
        }
    }
}
