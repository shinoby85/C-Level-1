using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnyTasks
{

    class MassWithConstruct
    {
        int[] myMass;
        public MassWithConstruct()
        {
            myMass = new int[1] { 0 };
        }
        /// <summary>
        /// Инициализация массива
        /// </summary>
        /// <param name="razm">Размерность массива</param>
        /// <param name="startNum">Начальное значение чисел</param>
        /// <param name="step">Шаг для добавляемого числа</param>
        public MassWithConstruct(int razm, int startNum, int step)
        {
            if (razm<=0)
            {
                razm = 0;
            }
            switch (razm)
            {
                case 0:
                    myMass = new int[1] { 0 }; break;
                case 1:
                    myMass = new int[1] {startNum}; break;
                default:
                    {
                        myMass = new int[razm];
                        myMass[0] = startNum;
                        for (int i = 1; i < razm; i++)
                        {
                            startNum += step;
                            myMass[i] = startNum;
                        }
                        break;
                    }
            }
            
        }
    }

    static class StaticClass
    {
        /// <summary>
        /// Выводит данные массива на консоль
        /// </summary>
        /// <param name="mas">Передаваемый массив</param>
        static void OutputMass(int[] mas)
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
        public static int PairNumber(int[] mas, int num)
        {
            int col = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] % num == 0 ^ mas[i + 1] % num == 0)
                {
                    col++;
                }
            }
            return col;
        }        
        /// <summary>
        /// Чтение данных массива из текстового файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Массив целых чисел</returns>
        static int[] ReadMass(string fileName)
        {
            int[] mass;
            try
            {
                StreamReader streamFile = new StreamReader(fileName);
                string str = streamFile.ReadLine();
                string[] num = str.Split(' ');
                mass = new int[num.Length];
                for (int i = 0; i < num.Length; i++)
                {
                    mass[i] = int.Parse(num[i]);
                }
                return mass;
            }
            catch (Exception)
            {
                Console.WriteLine("Указаный файл не существует. Возвращаемое значение: 0.");
                return mass =new int[1]{0};
            }
        }
        public static void LTask41(string filename)
        {
            OutputMass(ReadMass(filename));            
            Console.WriteLine($"\nКоличество найденных пар: {PairNumber(ReadMass(filename), 3)}");
        }
    }

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

        /// <summary>
        /// Задание 4-2
        /// </summary>
        public void Task_4_2()
        {
            StaticClass.LTask41("mass.txt");
            Console.ReadKey();
        }
      
        public void Task_4_3()
        {

        }





    }
}
