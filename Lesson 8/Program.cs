using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;



namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Понкратьев Евгений
             * Задание 1.	С помощью рефлексии выведите все свойства структуры DateTime.*/
                         
            var myObj = typeof(DateTime);
            foreach (var item in myObj.GetProperties())
            {
                var str = item.ToString().Split(' ');
                Console.WriteLine(str[1]);
            }
            Console.ReadKey();
            /* Задание 2. 2.	Создайте простую форму на котором свяжите свойство 
             * Text элемента TextBox со свойством Value элемента NumericUpDown */

            FZ2 myForm2 = new FZ2();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(myForm2);
            
            
        }
    }
}
