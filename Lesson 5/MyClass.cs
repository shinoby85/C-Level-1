using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public Message(string str)
        {
            myString = str;
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

    }
}
