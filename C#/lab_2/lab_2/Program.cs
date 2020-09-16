using System;
using System.Text;

namespace lab_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          
            Console.WriteLine("Введите число k:");
            string number = Console.ReadLine();
            double num = Convert.ToDouble(number);
         
            double form_main = (Math.Pow(num, 2) - 3) / (Math.Pow(num,2)-(Math.Pow(-1, num) * num) + 3);
            Console.WriteLine($"Результат: {form_main}");

        }
    }
}
