using System;

namespace Basic_of_.Net_Fremework
{
    class Program:Unit
    {
        static void Main(string[] args)
        {
            int n, x, i;
            do Console.Write("Число:");
            while (!int.TryParse(Console.ReadLine(), out n));
            do Console.Write("Пропишите исчислительную систему(от 2 до 20):");
            while (!int.TryParse(Console.ReadLine(), out i));
            while(i<2||i>20)
            {
                Console.Write("Пропишите правильно исчислительную систему:");
                int.TryParse(Console.ReadLine(), out i);
            }
            x = n;
                string s = n == 0 ? "0" : "";
                while (x > 0)
                {
                    s = x % i + s;
                    x /= i;
                }
                Console.WriteLine("{0}-я:{1}", i, s);
            Console.ReadKey();
            string str = "aaaabbaaccde";
            int[] a = new int[10] { 1, 2, 3, 5 ,5 ,5 ,3 ,4 ,5 ,4 };
            Console.Write(maxRepeatingint(a));
            Console.Write(maxRepeating(str));
            Console.Write(maxnoRepeating(str));
        }

    }
}
