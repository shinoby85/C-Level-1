using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;



namespace AnyTasks
{
    class DataFunction_L5
    {
        /// <summary>
        /// Представляет собой данные одного учащегося
        /// </summary>
        class EGClass
        {
            string surname;
            string name;
            int[] number;
            public double srB;

            /// <summary>
            /// Добавляет новые данные в класс
            /// </summary>
            /// <param name="data"></param>
            public EGClass(string[] data)
            {
                number = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    switch (i)
                    {
                        case 0: surname = data[i];
                            break;
                        case 1: name = data[i];
                            break;
                        default:
                            number[i - 2] = int.Parse(data[i]);
                            break;
                    }
                }

            }
            /// <summary>
            /// Выдает среднее-арифмитическое по баллам
            /// </summary>
            public double srSumma
            {
                get{
                    int sum = 0;
                    foreach (var item in number)
                    {
                        sum += item;
                    }
                    srB= (double)sum / (double)number.Length;
                    return srB;
                }
            }
            /// <summary>
            /// Выводит текущее состояние объекта
            /// </summary>
            public void OutputData()
            {
                    Console.WriteLine($"Фамилия: {surname}, Имя: {name}, Средний бал: {srB}.");
            }
        }



        /// <summary>
        /// Производит сортировку символов в строке
        /// </summary>
        /// <param name="str">Передаваемая строка</param>
        /// <returns>Отсортированное значение строки</returns>
        static string SortStr(string str)
        {
            char[] chStr = str.ToCharArray();
            for (int i = 0; i < chStr.Length-1; i++)
            {
                for (int j = i+1; j <chStr.Length; j++)
                {
                    if (chStr[i]>chStr[j])
                    {
                        char ch = chStr[i];
                        chStr[i] = chStr[j];
                        chStr[j] = ch;
                    }
                }
            }
            string mystr = "";
            foreach (var item in chStr)
            {
                mystr += item;
            }
            return mystr;           
        }
        /// <summary>
        /// Проверка строк на возможную перестановку
        /// </summary>
        /// <param name="str1">Первая строка</param>
        /// <param name="str2">Вторая строка</param>
        /// <returns>Результат сравнения</returns>
        static bool AnalizStr(string str1, string str2)
        {
            if (str1==null||str2==null )
            {
                return false;
            }
            if (str1.Length!=str2.Length)
            {
                return false;
            }
            
            var newStr1 = SortStr(str1);
            var newStr2 = SortStr(str2);
            for (int i = 0; i < newStr1.Length; i++)
            {
                if ((int)newStr1[i]!= (int)newStr2[i])
                {
                    return false;
                }
            }
            return true; ;
        }



        /// <summary>
        /// Производит частотный анализ текста
        /// </summary>
        /// <param name="mWord">Массив слов</param>
        /// <param name="text">Анализируемый текс</param>
        /// <returns>Библиотека частотных вхождений</returns>
        static Dictionary<string,int> AnalizData(string[] mWord,string text)
        {
            Dictionary<string, int> myLibruary = new Dictionary<string, int>();
            Regex regex;
            foreach (var elStr in mWord)
            {
                int count = 0;
                regex = new Regex($@"\b{elStr}(\b|\W)");
                if (regex.IsMatch(text))
                {
                    foreach (var item in regex.Matches(text))
                    {
                        count++;
                    }
                }
                myLibruary.Add(elStr, count);
            }
            return myLibruary;
        }
        /// <summary>
        /// Решение задания 2D с занятия 5
        /// </summary>
        public void Task_5_2d()
        {
            string[] masWord = new string[]{"home","data","mygroup","legend","metric","coral","meta"};
            string fileText = File.ReadAllText(@"..\..\massWord.txt");

            var myData=AnalizData(masWord, fileText);
            foreach (var item in myData)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        /// <summary>
        /// Решение задания 3
        /// </summary>
        public void Task_5_3()
        {
            string str1, str2;
            Console.Write("Введите строку 1: ");
            str1=Console.ReadLine();
            Console.Write("Введите строку 2: ");
            str2 = Console.ReadLine();
            if (AnalizStr(str1,str2))
            {
                Console.WriteLine("Строка является перестановкой.");
            }
            else
                Console.WriteLine("Строка не является перестановкой.");
        }

        public void Task_5_4()
        {
            EGClass[] mySchoolClass;
            double[] MinUser={0,0,0};
            
            StreamReader strRead = new StreamReader("..\\..\\dataEGE54.txt");
            int num = int.Parse(strRead.ReadLine());
            mySchoolClass = new EGClass[num];
            bool flag = true;
            
            for (int i = 0; i < num; i++)
            {
                string[] data = strRead.ReadLine().Split(' ');
                mySchoolClass[i]=new EGClass(data);
                if (flag)
                {
                    MinUser[2] = mySchoolClass[0].srSumma;
                    flag = false;
                }
                if (MinUser[2] > mySchoolClass[i].srSumma)
                {
                    MinUser[0] = MinUser[1];
                    MinUser[1] = MinUser[2];
                    MinUser[2] = mySchoolClass[i].srSumma;
                }
                
            }
            foreach (var item in mySchoolClass)
            {
                if (item.srB==MinUser[0]|| item.srB == MinUser[1] || item.srB == MinUser[2] )
                {
                    item.OutputData();
                }
            }
        }




    }
}
