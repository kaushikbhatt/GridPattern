using System;

namespace section23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0;
            Console.WriteLine("m input");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n input");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m / 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n / 2; j++)
                {

                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
