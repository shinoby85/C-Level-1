using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Lesson_5
{
    class MyClass
    {
        private static string login;

        public MyClass(string inputLog)
        {
            login = inputLog;
        }

        /// <summary>
        /// Ищет совпадение введенного значения с шаблоном регулярного выражения
        /// </summary>        
        /// <returns>Результат соответствия</returns>
        public bool CheckRegular
        {
            get
            {
                string regular = @"^\D[a-zA-Z0-9]{1,9}$";
                Regex reg = new Regex(regular);
                if (reg.IsMatch(login))
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
               /// Анализирует полученную строку на соответствие указанному шаблону
               /// </summary>
        public bool CheckString
        {
            get
            {
                
                if (char.IsDigit(login[0])==true)
                {
                    return false;
                }
                StringBuilder logStr = new StringBuilder(login);
                if (logStr.Length<2||logStr.Length>10)
                {
                    return false;
                }
                for (int i = 0; i < logStr.Length; i++)
                {
                    if (logStr[i]==' ')
                    {
                        return false;
                    }
                }
                
                return true;
            }
        }

        
    }
    class Message
    {
        private static string myString;
        private static string fileString;
        private static int indMaxElem;

        public Message(string str)
        {
            myString = str;
            fileString = null;
            indMaxElem = 0;
        }

        /// <summary>
        /// Вывод слоа с сообщением в тексте до n символов
        /// </summary>
        /// <param name="num">Требуемая ширина слов</param>
        public void OutpuData(int num)
        {
            string regular = @"\b[a-zA-z]{1," + num.ToString()+ @"}\b";
            Regex myReq = new Regex(regular);
            MatchCollection outData = myReq.Matches(myString);
            foreach (var item in outData)
            {
                Console.WriteLine(item.ToString());
            }
            
                
            
        }
        /// <summary>
        /// Удаляет слово из строки если оно заканчивается на указанный символ
        /// </summary>
        /// <param name="ch">Символ конца слова</param>
        public void DeleteWord (char ch)
        {
            string serchRegular = @"(\s|\b)[a-zA-Z0-9]{1,}"+ch.ToString()+@"(\b|\s)";
            Regex serch = new Regex(serchRegular);

            string result = Regex.Replace(myString, serchRegular, String.Empty);
            Console.WriteLine(result.ToString());


        }
        /// <summary>
        /// Читает содержимое текстового файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public void ReadFile(string fileName)
        {
            StreamReader rf = new StreamReader("..\\..\\"+fileName);
            fileString = rf.ReadLine();
        }

        /// <summary>
        /// Указывает максимальное слово в строке
        /// </summary>
        public string MaxWord
        {
            get
            {
                string[] str = fileString.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
                int index = 0;
                for (int i = 0; i < str.Length-1; i++)
                {
                    if (str[index].Length<str[i+1].Length)
                    {
                        index = i+1;
                    }
                    
                }
                indMaxElem = index;
                return str[index];
            }
        }
        /// <summary>
        /// Формирование строки из максимальных по длине слов
        /// </summary>
        public void MasMaxWord()
        {
            string[] str = fileString.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder mas = new StringBuilder();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[indMaxElem].Length == str[i].Length)
                {
                    mas.Append(str[i]);
                }
            }
            Console.Write("Самые длинные слова в строке:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($" {mas[i]}");
            }
           //return true;
        }
    }
}
