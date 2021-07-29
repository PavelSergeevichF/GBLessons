using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLess.Properties
{
    class Class5
    {
        public static void OutputInCenter()
        {
            Console.WriteLine("Введите имя");
            string nameUser = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surnameUser = Console.ReadLine();
            Console.WriteLine("Введите возрост");
            string cityUser = Console.ReadLine();

            Console.WriteLine("Написать программу, которая выводит на экран ваше имя, фамилию и город проживания");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("Имя {0}, фамилия {1}, возрост {2}", nameUser, surnameUser, cityUser);
            Console.ReadLine();
        }
    }
}
