using System;

namespace FindTheDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ListNb = new int[8];
            var rand = new Random();
            int Theduplicate = 0;
            
            for(int i=0; i<8;i++)
            {
                ListNb[i] = rand.Next(1, 10);
                Console.WriteLine(ListNb[i]);
            }
            Console.WriteLine(" ");

                for (int j = 0; j < ListNb.Length; j++)
                {
                    for (int i = 0; i < ListNb.Length; i++)
                    {
                        if (ListNb[i] == ListNb[j] && i != j)
                        {
                            Theduplicate = ListNb[i];

                            Console.WriteLine(Theduplicate);
                    }
                    }
                }
            Console.WriteLine(Theduplicate);
            Console.ReadKey();
        }
    }
}