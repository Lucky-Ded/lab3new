using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            //считывание данных о нажатой клавиши 
            ConsoleKeyInfo key = Console.ReadKey();

            //получение символа нажатой клавиши (если возможно) 
            char ch = key.KeyChar;

            if (ch == '-') Console.WriteLine("{0}", a - b);

            if (ch == '+') Console.WriteLine("{0}", a + b);

            if (ch == '*') Console.WriteLine("{0}", a * b);

            if (ch == '/') Console.WriteLine("{0}", a / b);



            Console.ReadKey();
        }
    }
}
