using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IDraw
    {
        void Draw();
    }

    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract string Color { get; }
        public abstract int Kolvo { get; set; }
        public abstract double perimetr();
        public abstract double ploshad();
        public abstract void console(string n, string c, int k, double p, double pl);

    }
    class Square : Shape, IDraw
    {
        Random rand = new Random();
        string n, c;
        int k;
        public override int Kolvo
        {
            get => k;
            set => k = value;
        }
        public override double perimetr()
        {
            return 4 * k;
        }
        public override double ploshad()
        {
            return k * k;
        }
        public override void console(string n, string c, int k, double p, double pl)
        {
            Console.WriteLine("Name: " + n + " Color: " + c + " Size: " + k);
            Console.WriteLine("Perimetr: " + p + " Ploshad: " + pl);
            Console.WriteLine(" ");
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public Square(string a)
        {
            n = a;
            c = "red";
            k = rand.Next() % 50;
            Draw();
            console(n, c, k, perimetr(), ploshad());
        }
        public override string Name
        {
            get => n;
        }
        public override string Color
        {
            get => c;
        }
    }
    class Triangle : Shape, IDraw
    {
        string n, c;
        int k;
        public override int Kolvo
        {
            get => k;
            set => k = value;
        }
        public override double perimetr()
        {
            return k * 3;
        }
        public override double ploshad()
        {
            return (k * k * Math.Sqrt(3)) / 4;
        }
        public override void console(string n, string c, int k, double p, double pl)
        {
            Console.WriteLine("Name: " + n + " Color: " + c + " Size: " + k);
            Console.WriteLine("Perimetr: " + p + " Ploshad: " + pl);
            Console.WriteLine(" ");
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public Triangle(string a, int e)
        {
            n = a;
            c = "blue";
            k = e;
            Draw();
            console(n, c, k, perimetr(), ploshad());
        }
        public override string Name
        {
            get => n;
        }
        public override string Color
        {
            get => c;
        }
    }
    class Circle : Shape, IDraw
    {
        string n, c;
        int k;
        public override int Kolvo
        {
            get => k;
            set => k = value;
        }
        public override double perimetr()
        {
            return 2 * k * Math.PI;
        }
        public override double ploshad()
        {
            return k * Math.PI * k;
        }
        public override void console(string n, string c, int k, double p, double pl)
        {
            Console.WriteLine("Name: " + n + " Color: " + c + " Size: " + k);
            Console.WriteLine("Perimetr: " + p + " Ploshad: " + pl);
            Console.WriteLine(" ");
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public Circle(string a, string b, int e)
        {
            n = a;
            c = b;
            k = e;
            Draw();
            console(n, c, k, perimetr(), ploshad());
        }
        public override string Name
        {
            get => n;
        }
        public override string Color
        {
            get => c;
        }
    }
    class Picture : Shape, IDraw
    {
        string n, c;
        Random rand = new Random();
        int k = 0;
        int d = 0;
        int jj = 0;
        string[] name = { "kvadrat", "romb", "pryamougolnik", "circle", "triangle" };
        string[] color = { "DarkGreen", "DarkRed", "Magenta", "White", "Cyan" };
        List<Shape> jets;
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;//цвет добавленных фигур
        }
        public void Draw2()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public void Draw3()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public void Draw4()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Draw5()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public Picture()
        {
            string c;
            string n;
            int e = rand.Next() % 4;
            for (int i = 0; i < e; i++)
            {
                jets = new List<Shape>();
                k = rand.Next() % 50 + 1;
                d = rand.Next() % 50 + 1;
                int cou = rand.Next() % 4;
                c = color[cou];
                if (cou == 0)
                {
                    Draw();
                }
                else if (cou == 1)
                {
                    Draw2();
                }
                else if (cou == 2)
                {
                    Draw3();
                }
                else if (cou == 3)
                {
                    Draw4();
                }
                else
                {
                    Draw5();
                }
                int y = rand.Next() % 4;
                n = name[y];
                if (y == 0) { jj = 0; console(n, c, k, perimetr(), ploshad()); }
                else if (y == 1) { jj = 1; console(n, c, k, perimetr(), ploshad()); }
                else if (y == 2) { jj = 2; console(n, c, k, perimetr(), ploshad()); }
                else if (y == 3) { jj = 3; console(n, c, k, perimetr(), ploshad()); }
                else if (y == 4) { jj = 4; console(n, c, k, perimetr(), ploshad()); }
            }
        }
        public Picture(int len)
        {
            jets = new List<Shape>();
            Draw();
        }
        public override int Kolvo
        {
            get => k;
            set => k = value;
        }
        public override double perimetr()
        {
            if (jj == 0) { return k * 4; }
            else if (jj == 1) { return k * 4; }
            else if (jj == 2) { return 2 * k + 2 * d; }
            else if (jj == 3) { return 2 * k * Math.PI; }
            else { return k * 3; }
        }
        public override double ploshad()
        {
            if (jj == 0) { return k * k; }
            else if (jj == 1) { return k * d; }
            else if (jj == 2) { return k * d; }
            else if (jj == 3) { return k * Math.PI * k; }
            else { return (k * k * Math.Sqrt(3)) / 4; }
        }
        public override void console(string n, string c, int k, double p, double pl)
        {
            Console.WriteLine("Name: " + n + " Color: " + c + " Size: " + k);
            Console.WriteLine("Perimetr: " + p + " Ploshad: " + pl);
            Console.WriteLine(" ");
        }
        void add(Shape jet)
        {
            jets.Add(jet);
        }
        void del(int i)
        {
            //jets.Clear();
            jets.RemoveAt(i);
        }
        public int kolvo { get; }
        public override string Name
        {
            get => n;
        }
        public override string Color
        {
            get => c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size circle: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Enter size tregolnik: ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Square kvadrat = new Square("kvadrat");
            Circle krug = new Circle("krug", "Yellow", e);
            Triangle treugl = new Triangle("treugolnik", q);
            Picture figure = new Picture();
        }
    }
}
