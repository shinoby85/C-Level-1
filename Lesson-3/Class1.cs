using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Drob
    {
        //Целая часть
        private int cel;
        //Числитель
        private int chisl;
        //Знаменатель
        private int znam;
        public Drob() { }
        public Drob(int chisl1, int znam1)
        {
            this.cel = 0;
            this.chisl = chisl1;
            this.znam = znam1;
        }
        public int Cel
        {
            get { return cel; }
            set { cel = value; }
        }
        public int Chisl
        {
            get { return chisl; }
            set { chisl = value; }
        }
        public int Znam
        {
            get { return znam; }
            set { znam = value; }
        }
        public static Drob UprData(Drob a)
        {
            Drob data = new Drob();
            if (a.chisl > a.znam)
            {
                data.cel = a.chisl / a.znam;
                data.chisl = a.chisl % a.znam;
                data.znam = a.znam;
            }
            else
            {
                data = a;
            }
            for (int i = 2; i <=data.chisl&&data.chisl!=0; i++)
            {
                if (data.chisl%i==0 && data.znam%i==0)
                {
                    data.chisl /= i;
                    data.znam /= i;
                    --i;
                }
            }

            return data;
        }
        /// <summary>
        /// Поиск суммы двух дробей
        /// </summary>
        /// <param name="a">первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns>Результат сложения</returns>
        public static Drob Sum(Drob a, Drob b)
        {
            if (a.znam == 0 || b.znam == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0, проверьте выражения.");
            }
            else
            {
                Drob rez = new Drob();
                rez.chisl = a.chisl * b.znam + b.chisl * a.znam;
                rez.znam = a.znam * b.znam;
                return UprData(rez);
            }
        }
        /// <summary>
        /// Поиск разности двух дробей
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns>Результат вычитания</returns>
        public static Drob Razn(Drob a, Drob b)
        {
            if (a.znam == 0 || b.znam == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0, проверьте выражения.");
            }
            else
            {
                Drob rez = new Drob();
                rez.chisl = a.chisl * b.znam - b.chisl * a.znam;
                rez.znam = a.znam * b.znam;
                return UprData(rez);

            }
        }
        /// <summary>
        /// Умножение двух дробей
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Втора дробь</param>
        /// <returns>Результат умножения</returns>
        public static Drob Umnoj (Drob a, Drob b)
        {
            if (a.znam == 0 || b.znam == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0, проверьте выражения.");
            }
            else
            {
                Drob rez = new Drob();
                rez.chisl = a.chisl * b.chisl;
                rez.znam = a.znam * b.znam;
                return UprData(rez);

            }
        }
        /// <summary>
        /// Деление двух дробей
        /// </summary>
        /// <param name="a">Первая дробь</param>
        /// <param name="b">Вторая дробь</param>
        /// <returns>Результат деления</returns>
        public static Drob Del(Drob a,Drob b)
        {
            if (a.znam == 0 || b.znam == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0, проверьте выражения.");
            }
            else
            {
                Drob rez = new Drob();
                rez.chisl = a.chisl * b.znam;
                rez.znam = a.znam * b.chisl;
                return UprData(rez);

            }
        }

    }
}
