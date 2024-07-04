using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Info_Console());
                while (true)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.WriteLine("\n");
                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                    {
                        get_Students_Console();
                        break;
                    }
                    if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                    {
                        add_Student_Console();
                        break;
                    }
                    if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
                    {
                        delete_Student_Console();
                        break;
                    }
                    if (key == ConsoleKey.Escape)
                    {
                        Process.GetCurrentProcess().Kill();
                        break;
                    }
                } 
            }
            Console.ReadKey();
        }

        static Logic logic = new Logic();
        public static void get_Students_Console()
        {
            List<string> strings = logic.GetStudentsInfo();
            int count = 1;
            for (int i = 0; i < strings.Count(); i += 3)
            {
                Console.WriteLine($"{count}. {strings[i]} {strings[i + 1]} {strings[i + 2]}\n");
                count++;
            }
        }

        public static void add_Student_Console()
        {
            Console.Write("Введите имя студента:");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите группу студента:");
            string group = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите специальность студента:");
            string speaciality = Console.ReadLine();
            Console.WriteLine();
            logic.AddStudent(name, group, speaciality);
            Console.WriteLine("Студент успешно добавлен\n");
        }

        public static void delete_Student_Console()
        {
            Console.Write("Введите номер студента в списке:");
            int student = int.Parse(Console.ReadLine()) - 1;
            logic.DeleteStudent(student);
            Console.WriteLine("Студент успешно удалён\n");
        }

        public static string Info_Console()
        {
            string info = ($"1. Посмотреть список студентов\n" +
                                  $"2. Добавить студента\n" +
                                  $"3. Удалить студента\n" +
                                  $"Esc. Закрыть программу\n");
            return info;
        }
    }
}
