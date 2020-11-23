using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = new List<int>() { };
            Console.WriteLine("-----LENGHT YOUR NUMBER <11-----");
            Console.WriteLine("");
            Console.Write("You'r number: ");
            int q = 10;
            string consol = Console.ReadLine();
            int y = Convert.ToInt32(consol);
            int l = consol.Length;
            for (int i = 0; i < l - 2; i++)
            {
                q *= 10;
            }
            for (int i = 0; i < l; i++)
            {
                int r = y / q;
                if (i > 0)
                {
                    r %= 10;
                }
                chisla.Add(r);
                q /= 10;
            }
            Console.WriteLine("");
            for (int z = 0; z < l; z++)
            {
                int count = 0;
                for (int i = 0; i < l; i++)
                {
                    if (chisla[z] == chisla[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine("Chislo [" + chisla[z] + "]" + " Povtorilos: " + count + " raz");
                Console.WriteLine("");
            }
            Console.Write("Zagadaite chislo: ");
            int zagadka = Convert.ToInt32(Console.ReadLine());
            int za = 0;
            for (int i = 0; i < l; i++)
            {
                if (chisla[i] == zagadka)
                {
                    za++;
                }
            }
            if (za > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You'r number is GREAT!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You'r numbers don't searching!");
            }
        }
    }
}

