using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 4. *а) Реализовать класс для работы с двумерным массивом. 
             * Реализовать конструктор, заполняющий массив случайными числами. 
             * Создать методы, которые возвращают сумму всех элементов массива, 
             * сумму всех элементов массива больше заданного, 
             * свойство, возвращающее минимальный элемент массива, 
             * свойство, возвращающее максимальный элемент массива, 
             * метод, возвращающий номер максимального элемента массива 
             * (через параметры, используя модификатор ref или out)
             * *б) Добавить конструктор и методы, которые загружают данные из 
             * файла и записывают данные в файл. Дополнительные задачи
             * в) Обработать возможные исключительные ситуации при работе с файлами.*/

            Matr matrix = new Matr("inputArry.txt");
            Matr matrix1 = new Matr(4, 5, -150, 150);
            int indI, indJ;
            matrix.IndexMax(out indI,out indJ);
            Console.WriteLine($"В матрице Matrix максимальный элемент имеет позицию [{indI},{indJ}]");
            matrix1.IndexMax(out indI, out indJ);
            Console.WriteLine($"В матрице Matrix1 максимальный элемент имеет позицию [{indI},{indJ}]");
            Console.ReadKey();
        }
    }
}
