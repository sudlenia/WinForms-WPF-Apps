﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Logic BL = new Logic();
        //    while (true)
        //    {
        //        string _name = "ФИО студента";
        //        string _speci = "Специальность";
        //        string _group = "Группа";

        //        Console.WriteLine($"{_name,-20}     {_speci,-20}{_group,-20}\n\n");
        //        for (int i = 0; i < BL.ListOfStudents().Count; i += 3)
        //        {
        //            Console.WriteLine($"{(i + 1),3}. {BL.ListOfStudents()[i],-20}{BL.ListOfStudents()[i + 1],-20}{BL.ListOfStudents()[i + 2],-20}");
        //        }

        //        Console.WriteLine("Выберите, что вы желаете сделать: Добавить(кнопка Enter) или Удалить(кнопка Delete) студента");

        //        ConsoleKey key = Console.ReadKey().Key;

        //        while (key != ConsoleKey.Enter && key != ConsoleKey.Delete)
        //        {
        //            Console.WriteLine("\n\nВыберите одну из предложенных кнопок!");
        //            key = Console.ReadKey().Key;
        //        }

        //        if (BL.students.Count == 0 && key == ConsoleKey.Delete)
        //        {
        //            key = ConsoleKey.Enter;
        //            Console.WriteLine("Сейчас вы можете только добавлять, поскольку список пуст!\nМы вынужденно меняем ваш выбор");
        //        }



        //        if (key == ConsoleKey.Enter)
        //        {
        //            Console.WriteLine("Напишите имя студента");
        //            string name = Console.ReadLine();
        //            Console.WriteLine("Напишите специальность студента");
        //            string speciality = Console.ReadLine();
        //            Console.WriteLine("Напишите группу студента");
        //            string group = Console.ReadLine();


        //            BL.AddStudent(name, speciality, group);
        //        }

        //        if (key == ConsoleKey.Delete)
        //        {
        //            Console.WriteLine("Напишите номер студента");

        //            int number = Convert.ToInt32(Console.ReadLine());

        //            while (number < 0 && number > (BL.ListOfStudents().Count / 3))
        //            {
        //                Console.WriteLine("\n\nВведите допустимое значение!");
        //                number = Convert.ToInt32(Console.ReadLine());
        //            }
        //            BL.DeleteStudent(number);
        //        }

        //        Console.WriteLine("Для выхода нажмите Esc, для продолжения любую кнопку");

        //        key = Console.ReadKey().Key;

        //        if (key == ConsoleKey.Escape)
        //        {
        //            break;
        //        }

        //        key = ConsoleKey.Backspace;
        //    }
        //}
    }
}
