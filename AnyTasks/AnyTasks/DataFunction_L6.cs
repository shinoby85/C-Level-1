using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace AnyTasks
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        int age;
        // Создаем конструктор
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="university">Наименование университета</param>
        /// <param name="faculty">Факультет</param>
        /// <param name="department">Кафедра</param>
        /// <param name="age">Возраст</param>
        /// <param name="course">Курс</param>
        /// <param name="group">Номер группы</param>
        /// <param name="city">Название города студента</param>
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }


    class DataFunction_L6
    {
        static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }

        public void Task_6_2() {

            int courseStudent = 0;
            int[] ageStudent = new int[6] {0,0,0,0,0,0};
            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0],s[1],s[2],s[3],s[4],int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]),s[8]));
                    if (int.Parse(s[6])>=5 && int.Parse(s[6]) <= 6)
                    {
                        courseStudent++;
                    }
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        ageStudent[int.Parse(s[6])-1]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine($"Количество учащихся на 5 и 6 курсах составляет {courseStudent} человек.");
            Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет на курсах составляет:");
            int i = 1;
            foreach (var studentItems in ageStudent)
            {
                
                Console.WriteLine($"На {i} курсе - {studentItems,5} человек.");
                i++;
            }



            /*list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);*/
            



        }

    }
}
