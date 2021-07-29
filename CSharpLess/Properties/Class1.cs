using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLess.Properties
{
    class Class1
    {
        
        public static void questionnaire()
        {
            Console.WriteLine("Введите имя");
            string nameUser = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surnameUser = Console.ReadLine();
            Console.WriteLine("Введите возрост");
            string ageUser = Console.ReadLine();
            Console.WriteLine("Введите рост");
            string heightUser = Console.ReadLine();
            Console.WriteLine("Введите вес");
            string weightUser = Console.ReadLine();
            var d = -123456.7890123;

            Console.WriteLine("используя склеивание");
            Console.WriteLine("Имя "+ nameUser+", фамилия "+ surnameUser + ", возрост "+ ageUser+ ", рост "+ heightUser + ", вес "+ weightUser);
            Console.ReadLine();

            Console.WriteLine("используя форматированный вывод");
            Console.WriteLine("Имя {0}, фамилия {1}, возрост {2:D}, рост {3:D}, вест {4:D}", nameUser, surnameUser, ageUser, heightUser, weightUser);
            Console.ReadLine();

            Console.WriteLine("используя вывод со знаком $");
            Console.WriteLine($"{d}");
            Console.ReadLine();
        }

    }
}
