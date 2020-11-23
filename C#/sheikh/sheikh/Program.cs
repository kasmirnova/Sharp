using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program : Garage
    {
        static void Main(string[] args)
        {
            List<Auto> cars = new List<Auto>() { };
            while (true)
            {
                Console.WriteLine("BUY A NEW CAR?  (1-yes) (2-no) (0-exit)");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    NewCar(cars);
                    continue;
                }
                else if (a == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("PRODAT-1    VZYAT-2");
                        int v = Convert.ToInt32(Console.ReadLine());
                        if (v == 1)
                        {
                            Console.WriteLine("KOL-VO CARS: " + cars.Count);
                            Console.WriteLine(" ");
                            int n_c = 1;
                            foreach (Auto n in cars)
                            {
                                Console.WriteLine(n_c++);
                                Console.WriteLine(n.NAME);
                                Console.WriteLine(n.COLOR);
                                Console.WriteLine(n.DATE);
                                Console.WriteLine(n.SPEED);
                            }
                            Console.Write("KAKUY PRODAEM?");
                            int kak = Convert.ToInt32(Console.ReadLine());
                            cars.RemoveAt(kak - 1);
                            break;
                        }
                        else if (v == 2)
                        {
                            Console.WriteLine("KOL-VO CARS: " + cars.Count);
                            int krit;
                            Console.WriteLine("KRITERII: 1(name) 2(color) 3(date) 4(speed)");
                            krit = Convert.ToInt32(Console.ReadLine());
                            if (krit == 1)
                            {
                                Console.Write("NAME: ");
                                string n = Console.ReadLine();
                                for (int i = 0; i < cars.Count; i++)
                                {
                                    foreach (Auto e in cars)
                                    {
                                        if (e.NAME == n)
                                        {
                                            Console.WriteLine("YOUR CAR NUMBER: " + i);
                                            Console.WriteLine(e.NAME);
                                            Console.WriteLine(e.COLOR);
                                            Console.WriteLine(e.DATE);
                                            Console.WriteLine(e.SPEED);
                                        }
                                    }
                                }
                            }
                            else if (krit == 2)
                            {
                                Console.Write("COLOR: ");
                                string n = Console.ReadLine();
                                for (int i = 0; i < cars.Count; i++)
                                {
                                    foreach (Auto e in cars)
                                    {
                                        if (e.COLOR == n)
                                        {
                                            Console.WriteLine("YOUR CAR NUMBER: " + i);
                                            Console.WriteLine(e.NAME);
                                            Console.WriteLine(e.COLOR);
                                            Console.WriteLine(e.DATE);
                                            Console.WriteLine(e.SPEED);
                                        }
                                    }
                                }
                            }
                            else if (krit == 3)
                            {
                                Console.Write("DATE: ");
                                string n = Console.ReadLine();
                                for (int i = 0; i < cars.Count; i++)
                                {
                                    foreach (Auto e in cars)
                                    {
                                        if (e.DATE == n)
                                        {
                                            Console.WriteLine("YOUR CAR NUMBER: " + i);
                                            Console.WriteLine(e.NAME);
                                            Console.WriteLine(e.COLOR);
                                            Console.WriteLine(e.DATE);
                                            Console.WriteLine(e.SPEED);
                                        }
                                    }
                                }
                            }
                            else if (krit == 4)
                            {
                                Console.Write("SPEED: ");
                                string n = Console.ReadLine();
                                for (int i = 0; i < cars.Count; i++)
                                {
                                    foreach (Auto e in cars)
                                    {
                                        if (e.SPEED == n)
                                        {
                                            Console.WriteLine("YOUR CAR NUMBER: " + i);
                                            Console.WriteLine(e.NAME);
                                            Console.WriteLine(e.COLOR);
                                            Console.WriteLine(e.DATE);
                                            Console.WriteLine(e.SPEED);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("---");
                                Console.WriteLine("Error 7 - no number or menu");
                                Console.WriteLine("---");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hey, write number menu else!");
                            continue;
                        }
                    }
                }
                else if (a == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hey, write number menu else!");
                    continue;
                }

            }
        }
        static void NewCar(List<Auto> cars)
        {
            while (true)
            {
                Console.WriteLine("----------ADD NEW CAR----------");
                Console.Write("NAME: ");
                string q = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Write("COLOR: ");
                string w = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Write("DATE: ");
                string e = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Write("SPEED: ");
                string r = Console.ReadLine();
                cars.Add(new Auto() { NAME = q, COLOR = w, DATE = e, SPEED = r });
                break;
            }
        }
    }
    public class Garage
    {

        public class Auto
        {
            public string NAME { get; set; }
            public string COLOR { get; set; }
            public string DATE { get; set; }
            public string SPEED { get; set; }
        }

    }
}

