using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLess.Properties
{
    class Class3
    {
        static int x1=0,x2=0,y1=0,y2=0;
        public static void calculatingDistance()
        {
            double r;
            Console.WriteLine("Введите x1");  x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");  y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");  x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");  y2 = Convert.ToInt32(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x2, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками с координатами x1, y1 и x2,y2 {0:F2}",r);
            Console.ReadLine();
        }
    }
}
