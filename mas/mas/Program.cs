using System;
using System.Text;
namespace mas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;
            Random rand = new Random();
            Console.WriteLine("Введи длину : ");
            a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            for(int i=0;i<a;i++)
            {
                array[i] = rand.Next(-100,100);
                Console.WriteLine(array[i]);
            }
            int plus=0, minus=0;
            for(int i=0;i<a;i++)
            {
                if(array[i]>0)
                {
                    plus++;
                }
                else if(array[i]<0)
                {
                    minus++;
                }
            }
            int allrange = a + plus + minus;
            int[] rearray = new int[allrange];
            for(int i=0;i<allrange;i++)
            {
                rearray[i] = 0;
            }
            int count = 0;
            while (count < allrange)
            {
                for (int r = 0; r < a; r++)
                {
                    if (array[r] > 0)
                    {
                        rearray[count] = 0;
                        rearray[count + 1] = array[r];
                        count += 2;
                    }
                    else if(array[r]<0)
                    {
                        rearray[count] = array[r];
                        rearray[count+1] = 0;
                        count += 2;
                    }
                }
            }
            Console.WriteLine("NEW MASIIVE");
            for(int i=0;i<allrange;i++)
            {
                Console.WriteLine(rearray[i]);
            }

        }
    }
}
