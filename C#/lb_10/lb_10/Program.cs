using System;

namespace lb_10
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //CHISLOREVERSE
            Console.Write("Chislo: ");
            string s = Console.ReadLine();
            int y = 0;
            y.chisla1(s);
            //BUKVIREVERSE
            Console.Write("Works: ");
            string e = Console.ReadLine();
            e.slova1(e);
            //DROBREVERSE
            Console.Write("Drob: ");
            string drob = Console.ReadLine();
            drob.slovaznak1(drob);
            //zadanie 4
            Console.Write("BUKVI+ZNAK: ");
            string slovo = Console.ReadLine();
            slovo.slovaznak1(slovo);
            //MASSIV
            Console.Write("vvedite massiv: ");
            string massiv = Console.ReadLine();
            int[] r = { 1, 2, 3 };
            r.mase(massiv);
            Console.WriteLine(" ");
            Console.Write("vvedite massiv: ");
            Console.WriteLine(" ");
            int[] re = { 1, 4, 5, 6, 4, 3, 2, 3, 4, 5, 3, 5 };
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                re[i] = 15 - rand.Next() % 30;
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write(re[i] + " ");
            }
            Console.WriteLine(" ");
            re.rever(re);
        }
    }
    public static class metods
    {
        public static int chisla1(this int str, string s)
        {
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
            return 0;
        }
        public static string slova1(this string srt, string e)
        {
            char[] eReverse = e.ToCharArray();
            Array.Reverse(eReverse);
            e = new string(eReverse);
            Console.WriteLine(e);
            return " ";
        }
        public static string slovaznak1(this string srt, string slovo)
        {
            int save = 0;
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == ',')
                {
                    save = i + 1;
                    break;
                }
            }
            string first = "";
            for (int i = 0; i < save - 1; i++)
            {
                first += slovo[i];
            }
            string second = "";
            for (int i = save; i < slovo.Length; i++)
            {
                second += slovo[i];
            }
            char[] fir = first.ToCharArray();
            Array.Reverse(fir);
            string bn = new string(fir);
            char[] sec = second.ToCharArray();
            Array.Reverse(sec);
            string nb = new string(sec);
            Console.WriteLine(bn + "," + nb);
            return " ";
        }
        public static double drobnie(this double str, string drob)
        {
            double con = Convert.ToDouble(drob);
            int ert = Convert.ToInt16(con);
            if (ert > con)
            {
                ert -= 1;
            }
            string rew = Convert.ToString(ert);
            int ret = drob.Length - 1 - rew.Length;//col-vo drobnix chisel
            int q = 1;
            for (int i = 0; i < ret; i++)
            {
                q *= 10;
            }
            int trop = Convert.ToInt16((con - ert) * q);
            string erw = Convert.ToString(trop);
            //Preobrazovanie
            char[] chis = rew.ToCharArray();
            Array.Reverse(chis);
            string p = new string(chis);
            char[] dros = erw.ToCharArray();
            Array.Reverse(dros);
            string o = new string(dros);
            Console.WriteLine(p + "," + o);
            return 3.0;
        }
        public static int[] mase(this int[] str, string massiv)
        {
            int[] a = { 1, 2 };
            Console.WriteLine(" ");
            for (int i = massiv.Length - 1; i >= 0; i--)
            {
                Console.Write(massiv[i]);
            }
            return a;
        }
        public static int[] rever(this int[] str, int[] array)
        {
            int a = array[0];
            for (int i = 1; i < 12; i++)
            {
                if (array[i] > a)
                {
                    a = array[i];
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = a;
                }
            }
            Console.WriteLine(" ");
            for (int i = 0; i < 12; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            return array;
        }
    }
}
