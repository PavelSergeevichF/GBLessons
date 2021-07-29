using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLess.Properties
{
    class Class2
    {
        static int height = 0, weight = 0;
        public static void indexHeightWeight()
        {
            Console.WriteLine("Введите рост");
            string heightUser = Console.ReadLine();
            Console.WriteLine("Введите вес");
            string weightUser = Console.ReadLine();


            height = Convert.ToInt32(heightUser);
            weight = Convert.ToInt32(weightUser);

            Console.WriteLine("Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h)");
            double h = height / 100;
            var I = weight / (h * h);
            Console.WriteLine("Индекс массы тела =" + I);
            Console.ReadLine();
        }
    }
}
