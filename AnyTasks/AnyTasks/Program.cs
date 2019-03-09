﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyTasks
{
   
   
    class Program
    {
        static void Main(string[] args)
        {
            /*Занятие 4. 
           * Задание 1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  
           * от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти 
           * и вывести количество пар элементов массива, в которых только одно число делится на 3. 
           * В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, 
           * для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. */
            // DataFunction T41 = new DataFunction();
            // T41.Task_4_1();

            /*Задание 2. Реализуйте задачу 1 в виде статического класса StaticClass;
             * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
             * б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
             * в)**Добавьте обработку ситуации отсутствия файла на диске.*/
            //DataFunction T42 = new DataFunction();
            //T42.Task_4_2();

            /*Задание 3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного 
             * размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает 
             * сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
             * (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, 
             * свойство MaxCount, возвращающее количество максимальных элементов. 
             * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
             * е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)*/
            DataFunction T43 = new DataFunction();
            T43.Task_4_3();


        }
    }
}
