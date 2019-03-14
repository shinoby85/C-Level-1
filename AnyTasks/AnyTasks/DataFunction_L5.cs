using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Text.RegularExpressions;


namespace AnyTasks
{
    



    class DataFunction_L5
    {

        struct Element
        {
            public string tag;
            public string str;
            // Создадим конструктор, чтобы проще было заполнить массив
            public Element(string tag, string newString)
            {
                this.tag = tag;
                str = newString;
            }
        }




        public void Tester()
        {

            string s = File.ReadAllText("data.txt");
            // Заполним массив элементов, сопоставив тегам соответствующий текст
            Element[] e = new Element[8] { new Element("name1","ООО 'Дружба'"),
                                         new Element("name2","Иванову И.И."),
                                         new Element("name3","менеджера по продажам"),
                                         new Element("name4","Сидорова А.А."),
                                         new Element("name5","Сидоров А.А."),
                                         new Element("data1","01.06.16"),
                                         new Element("data2","14.06.16"),
                                         new Element("data3","20.04.16"),

            };
            // Пробежимся по массиву и поменяем все вхождения тегов на текст
            foreach (var el in e)
            {
                Regex reg = new Regex("<" + el.tag + ">");
                s = reg.Replace(s, el.str);
            }
            Console.WriteLine(s);
            Console.ReadLine();







        }




    }
}
