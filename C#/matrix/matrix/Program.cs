using System;
using System.Text;
namespace matrix
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random ran = new Random();
            Console.Write("Кол-во рядов: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Кол-во колонок: ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int[,] matrix= new int [a,b];
            for(int i=0;i<a;i++)
            {
                for(int r=0;r<b;r++)
                {
                    matrix[i,r] = ran.Next(-5,40);
                    Console.Write(matrix[i, r]+" ");
                }
                Console.WriteLine(" ");
            }
            int c=0;//номер первого положительного столбика
            Console.WriteLine("CHISLO");
            int count = 0;
            for (int i = 0; i < b; i++)
            { 
                count = 0;
                for (int r = 0; r < a; r++)
                {
                    if(matrix[r,i]>0)
                    {
                        count++;
                    }
                }
                if(count==a)
                {
                    c = i;
                    break;//Если убрать бреак то меняться будет с последним положительным столбиком, если оставить то меняется с первым положительным столбиком.
                }
            }
            Console.WriteLine("PREOBRAZ"+" "+c);
            for (int r = 0; r < a; r++)
                {
                    int y = matrix[r, 0];
                    int m = matrix[r, c];
                    matrix[r, 0] = m;
                    matrix[r, c] = y;
                }
            for (int i = 0; i < a; i++)
            {
                for (int r = 0; r < b; r++)
                {
                    Console.Write(matrix[i, r] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
