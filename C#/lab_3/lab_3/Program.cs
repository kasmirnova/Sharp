using System;
using System.Text;
namespace lab_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите х: ");
            string number = Console.ReadLine();
            int x = Convert.ToInt32(number);
            Console.WriteLine("Введите у: ");
            string number1 = Console.ReadLine();
            int y = Convert.ToInt32(number1);
            if (x < 0 && y > 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}