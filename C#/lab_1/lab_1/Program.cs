using System;
using System.Text;


namespace lab_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double Pi = 3.14159265;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Заданный радиус: ");
            string radius = Console.ReadLine();
            double r = Convert.ToDouble(radius);
            double s = 4 * Pi * r * r;
            double v = (4 / 3) * Pi * r * r * r;
            Console.WriteLine($"Площадь: {s}");
            Console.WriteLine($"Объем: {v}");
            

        }
    }
}
