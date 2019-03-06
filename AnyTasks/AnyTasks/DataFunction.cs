using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyTasks
{
    class DataFunction
    {
        /// <summary>
        /// Заполняет массив случайными числами в указанном промежутке
        /// </summary>
        /// <param name="mas">Заполняемый массив</param>
        /// <param name="min">Нижний промежуток зачений</param>
        /// <param name="max">Верхний промежуток значений</param>
        void RndMass(int[] mas, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(min, max);
            }
        }
        /// <summary>
        /// Выводит данные массива на консоль
        /// </summary>
        /// <param name="mas">Передаваемый массив</param>
        void OutputMass(int[] mas)
        {
            Console.Write("Вид массива: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }
        /// <summary>
        /// Поиск количества пар чисел, одно из которых имеет указанный делитель
        /// </summary>
        /// <param name="mas">Передаваемый массив</param>
        /// <param name="num">Делитель</param>
        /// <returns>Количество пар</returns>
        int PairNumber(int[] mas, int num)
        {
            int col = 0;
            for (int i = 0; i < mas.Length-1; i++)
            {
                if (mas[i]%num==0 ^ mas[i+1]%num==0)
                {
                    col++;                    
                }
            }
            return col;
        }
        /// <summary>
        /// Задание 4-1
        /// </summary>
        public void Task_4_1()
        {
            int[] myMass = new int[20];
            int min = -10000;
            int max = 10000;
            RndMass(myMass, min, max);
            OutputMass(myMass);
            Console.WriteLine($"\nКоличество найденных пар: {PairNumber(myMass,3)}");            
            Console.ReadKey();
        }
      






    }
}
