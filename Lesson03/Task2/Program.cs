﻿using System;

namespace Task2
{
    //////1. Написать программу, выводящую элементы двумерного массива по диагонали.
    //2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов:первый элемент хранит имя контакта, второй — номер телефона/email.
    //////3. Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).
    //////*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
    class Program
    {
        static void Main(string[] args)
        {
            var array2D = new string[5, 2] { { "Сантехник" , "+7(495)111-11-11"}, { "Электрик", "+7(495)222-22-22" }, { "Сосед сверху", "+7(495)333-33-33" }, { "Сосед снизу", "+7(495)444-44-44" }, { "Не брать трубку", "+7(495)555-55-55" } }; ; // двухмерный массив из 5 строк и 2 столбцов.

            //array2D.Length = 10, т.е. сумма длин всех строк. array2D.GetLength(0) - длина самой верхней строки
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.Write(array2D[i, 0] + " " + array2D[i, 1]);
                Console.WriteLine();                
            }

            Console.ReadLine();
        }
    }
}
