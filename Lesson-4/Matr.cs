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
        /// Свойство возвращает минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min=matr[0,0];
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        if (matr[i,j]<min)
                        {
                            min = matr[i, j];
                        }

                    }
                }
                return min;
            }
        }
        /// <summary>
        /// Свойство возвращвет максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = matr[0, 0];
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        if (matr[i, j] > max)
                        {
                            max = matr[i, j];
                        }
                    }
                }
                return max;
            }
        }
        /// <summary>
        /// Осуществляет поиск индексов максимального элемента массива
        /// </summary>
        /// <param name="indI">Номер строки максимального элемента</param>
        /// <param name="indJ">Номер столбца максимального элемента</param>
        public void IndexMax(out int indI, out int indJ)
        {
            indI = 0;
            indJ = 0;
            int maxElem = matr[0, 0];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (maxElem<matr[i,j])
                    {
                        maxElem = matr[i, j];
                        indI = i;
                        indJ = j;
                    }
                }
            }
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
        /// <summary>
        /// Осуществляет подсчет суммы элементов массива
        /// </summary>
        /// <returns>Возвращает сумму элементов массива</returns>
        public int matrSum()
        {
            int sum = 0;
            for (int i = 0; i <matr.GetLength(0) ; i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sum += matr[i, j];
                }
            }
            return sum;
        }
        /// <summary>
        /// Возврат суммы элементов массива которые больше указанного значения
        /// </summary>
        /// <param name="number">Число, от значения которого будет происходить отбор</param>
        /// <returns>Результат сложения чисел с учетом критерия</returns>
        public int matrSum(int number)
        {
            int sum = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j]>=number)
                    {
                        sum += matr[i, j];
                    }                    
                }
            }
            return sum;
        }


    }
}
