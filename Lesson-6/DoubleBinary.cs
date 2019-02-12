using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_6
{
    public delegate double DataFunc(double arg);
    class DoubleBinary
    {
        /// <summary>
        /// Реализация функции 3
        /// </summary>
        /// <param name="x">Передаваемый оператор</param>
        /// <returns>Значение функции</returns>
        public static double F2(double x)
        { 
            return Math.Pow(Math.Pow((x + 4), 5), 1 / 3);
        }
        /// <summary>
        /// Реализация функции 2
        /// </summary>
        /// <param name="x">Передаваемый параметр</param>
        /// <returns>Результат функции</returns>
        public static double F1(double x)
        {
            return (2 * x + 1) / (3 * x - 1);
        }
        /// <summary>
        /// Реализация функции 1
        /// </summary>
        /// <param name="x">Параметр для подсчета   </param>
        /// <returns>Результат вычисления</returns>
            public static double F(double x)
            {
                return x * x - 50 * x + 10;
            }
        
            public static void SaveFunc(DataFunc MyFunk, double a, double b, double h)
            {
                FileStream fs = new FileStream("data.bin", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                double x = a;
                while (x <= b)
                {
                    bw.Write(MyFunk(x));
                    x += h;// x=x+h;
                }
                bw.Close();
                fs.Close();
            }

        
            public static double Load()
            {
                FileStream fs = new FileStream("data.bin", FileMode.Open, FileAccess.Read);
                BinaryReader bw = new BinaryReader(fs);
                double min = double.MaxValue;
                double d;
                for (int i = 0; i < fs.Length / sizeof(double); i++)
                {
                    // Считываем значение и переходим к следующему
                    d = bw.ReadDouble();
                    if (d < min) min = d;
                }
                bw.Close();
                fs.Close();
                return min;
            }

        
    }
}
