using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLess.Properties
{
    class Class4
    {
        static int num1 = 0, num2 = 0, temp;
        public static void exchange()
        {
            Console.WriteLine("Введите первое целое значение"); num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое значение"); num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Обмен через промежуточное значение");
            Console.WriteLine("num1= {0}, num2= {1}", num1, num2);
            Console.WriteLine("temp=num1;");
            Console.WriteLine("num1=num2;");
            Console.WriteLine("num2=temp;");
            temp = num1; num1 = num2; num2 = temp;
            Console.WriteLine("num1= {0}, num2= {1}", num1, num2);
            Console.WriteLine("num1 = num1 + num2; num2 = num1 - num2; num1 = num1 - num2;");
            num1 = num1 + num2; num2 = num1 - num2; num1 = num1 - num2;
            Console.WriteLine("num1= {0}, num2= {1}", num1, num2);
            Console.ReadLine();
        }
    }
}
