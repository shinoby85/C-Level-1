using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        /// <summary>
        /// Высчитывает расстояние между двумя точками
        /// </summary>
        /// <param name="x1">Координата Х первой точки</param>
        /// <param name="y1">Координата Y первой точки</param>
        /// <param name="x2">Координата Х второй точки</param>
        /// <param name="y2">Координата Y второй точки</param>
        /// <returns>Результат вычисления</returns>
        public static double Distance(double x1, double y1, double x2, double y2)
        {

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            Console.Write("Укажите координату X точки 1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите координату Y точки 1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите координату X точки 2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите координату Y точки 2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            //Вывод расстояния между двумя точками
            Console.Clear();
            Console.WriteLine($"Расстояние между указанными точками равно: {Distance(x1, y1, x2, y2):f2}");
            Console.WriteLine("Нажмите любую кнопку для выхода из приложения...");
            Console.ReadKey();
        }
    }
}