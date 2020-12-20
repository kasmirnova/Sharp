using System;

namespace lab_6
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //CHISLOREVERSE
            Console.Write("Chislo: ");
            string s = Console.ReadLine();
            chisla(s);
            //BUKVIREVERSE
            Console.Write("Works: ");
            string e = Console.ReadLine();
            slova(e);
            //DROBREVERSE
            Console.Write("Drob: ");
            string drob = Console.ReadLine();
            drobnie(drob);
            //zadanie 4
            Console.Write("BUKVI+ZNAK: ");
            string slovo = Console.ReadLine();
            BUKVIZNAK(slovo);
            //MASSIV
            Console.Write("vvedite massiv: ");
            string massiv = Console.ReadLine();
            string mask;
            reve(ref massiv);
            rev(out mask);
            Console.WriteLine(" ");
        }
        static void reve(ref string mas)
        {
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                Console.Write(mas[i]);
            }
        }
        static void rev(out string mask)
        {
            Console.WriteLine(" ");
            Console.Write("vvedite massiv: ");
            mask = Console.ReadLine();
            for (int i = mask.Length - 1; i >= 0; i--)
            {
                Console.Write(mask[i]);
            }
        }
        static void BUKVIZNAK(string slovo)
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
        }
        static void drobnie(string drob)
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
        }
        static void slova(string e)
        {
            char[] eReverse = e.ToCharArray();
            Array.Reverse(eReverse);
            e = new string(eReverse);
            Console.WriteLine(e);
        }
        static void chisla(string s)
        {
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
        }
    }
}
