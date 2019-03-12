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
        static int[] myMass;
        public MassWithConstruct()
        {
            myMass = new int[1] { 0 };
        }
        /// <summary>
        /// Рандомное заполнение массива целыми числами в промежутке от -10 до 10
        /// </summary>
        /// <param name="razm">Размерность массива</param>
        public MassWithConstruct(int razm)
        {
            razm = razm <= 0 ? 1 : razm;
            myMass = new int[razm];
            Random rnd = new Random();
            for (int i = 0; i < myMass.Length; i++)
            {
                myMass[i] = rnd.Next(-10, 10);
            }
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
                razm = 1;
            }
            switch (razm)
            {                
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
        /// <summary>
        /// Возврат из функции массива
        /// </summary>
        /// <returns>Возвращаемое значение</returns>
        public int[] Output
        {
            get
            {
                return myMass;
            }
        }
        /// <summary>
        /// Возвращает сумму всех элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < myMass.Length; i++)
                {
                    sum += myMass[i];
                }
                return sum;
            }
        }
        /// <summary>
        /// Возвращает инвертированный массив
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            int[] invMass = new int[myMass.Length];
            for (int i = 0; i < invMass.Length; i++)
            {
                invMass[i] =myMass[i] *(-1);
            }
            return invMass;
        }
        /// <summary>
        /// Умножает каждый элемент массива на число
        /// </summary>
        /// <param name="num">Множитель</param>
        public void Multi(int num)
        {
            for (int i = 0; i < myMass.Length; i++)
            {
                myMass[i] *= num;
            }
        }
        /// <summary>
        /// Поиск количества максимальных элементов
        /// </summary>
        public int MaxCount
        {
            get
            {
                int maxSearch = myMass[0];               
                int count = 1;
                foreach (var item in myMass)
                {
                    count=item > maxSearch ? 1 :count++;
                    maxSearch = item > maxSearch ? item:maxSearch;
                }
                return count;
            }
        }
        /// <summary>
        /// Формирует библиотеку вхождений
        /// </summary>
        public Dictionary<int,int> DataLibruary
        {
            get
            {
                int[] sortMass = new int[myMass.Length];
                for (int i = 0; i < myMass.Length; i++)
                {
                    sortMass[i] = myMass[i];
                }
                Array.Sort(sortMass);
                Dictionary<int, int> myLibruary=new Dictionary<int, int>();
                int count = 0, elem = sortMass[0];
                for (int i = 0; i < sortMass.Length; i++)
                {
                    if (elem!=sortMass[i])
                    {
                        myLibruary.Add(elem, count);
                        count = 0;
                        elem = sortMass[i];
                    }
                    count++;
                    
                }
                myLibruary.Add(elem, count);
                return myLibruary;
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

    class DataFunction_L4
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
            Console.Write("\nВид массива: ");
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
            //Console.ReadKey();
        }

        /// <summary>
        /// Задание 4-2
        /// </summary>
        public void Task_4_2()
        {
            StaticClass.LTask41("mass.txt");
            //Console.ReadKey();
        }
      
        public void Task_4_3()
        {
            MassWithConstruct T43 = new MassWithConstruct(12, -14, 7);
            OutputMass(T43.Output);
            Console.WriteLine($"\nСумма всех элементов масиива: {T43.Sum}.");
            OutputMass(T43.Inverse());
            Console.Write("\nУкажите множитель для массива:");
            int mnoj;
            if (int.TryParse(Console.ReadLine(),out mnoj))
            {
                T43.Multi(mnoj);
                OutputMass(T43.Output);
            }
            else
            {
                Console.WriteLine("Введенное значение не является числовым.");
            }
            Console.WriteLine($"\nВ массиве найдено {T43.MaxCount} одинаковых максимальных элементов.");
            MassWithConstruct T43_1 = new MassWithConstruct(25);
            OutputMass(T43_1.Output);
            Console.WriteLine("\nВывод элементов и их количества вхождений:");
            foreach (KeyValuePair<int,int> item in T43_1.DataLibruary)
            {                            
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }





    }
}
