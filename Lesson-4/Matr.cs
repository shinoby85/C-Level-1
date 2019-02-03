using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{
    class Matr
    {
        private int[,] matr;

        public int this[int ind1, int ind2]
        {
            get { return matr[ind1,ind2]; }
            set { matr[ind1,ind2] = value; }
        }
        /// <summary>
        /// Конструктор для инициализации двумерного массива случайными числами
        /// </summary>
        /// <param name="n">Количество строк массива</param>
        /// <param name="m">Количество столбцов</param>
        /// <param name="min">Нижняя граница для генерации случайных чисел</param>
        /// <param name="max">Верхняя граница для генерации случайных чисел</param>
        public Matr(int n, int m,int min,int max)
        {
            Random rnd = new Random();
            matr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = rnd.Next(min, max);
                }
            }
        }


        /// <summary>
        /// Конструктор считывает данные из файла и заносит их в массив
        /// </summary>
        /// <param name="fileName">Имя файла, с которого происходит считывание</param>
        public Matr(string fileName)
        {
            string[] str=null;
            try
            {
                str = File.ReadAllLines("..\\..\\" + fileName);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка доступа к файлу. Файл с указанным именем не найден."); ;
            }

            matr = new int[str.Length,stringLangth(str[0])];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < stringLangth(str[i]); j++)
                {
                    matr[i, j] = inputMasElement(str[i], j);
                }                 
             
            }
        }
        /// <summary>
        /// Выполняет подсчет количества элементов в строке
        /// </summary>
        /// <param name="str">Передаваемая строка</param>
        /// <returns>Количество элементов</returns>
        public static int stringLangth(string str)
        {          
            return str.Split(' ').Length;
        }
        /// <summary>
        /// Возвращает значение элемента в строке на который укзывает индекс
        /// </summary>
        /// <param name="str">Передаваемая строка</param>
        /// <param name="ind">Указатель на номер элемента в строке</param>
        /// <returns>Целое значение элемента строки</returns>
        public static int inputMasElement(string str, int ind)
        {
            var matr = str.Split(' ');
            return int.Parse(matr[ind]);
        }
    }
}
