using System;

namespace PrimeInput
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n, x;
            string nameList = "Matthew,Mark,Luke,John";
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            prime_num(n);

            Console.Write("Enter the Number the number of Fibonacci numbers: ");
            x = int.Parse(Console.ReadLine());
            Fibonacci_Iterative(x);
            name_define(nameList);

        }

        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0}, {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c;
            }
        }

        static void prime_num(int num)
        {
            var line = string.Empty;
            for (int i = 0; i <= num; i++)
            {
                bool isPrime = true; // Move initialization to here
                for (int j = 2; j < i; j++) // you actually only need to check up to sqrt(i)
                {
                    if (i % j == 0) // you don't need the first condition
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    if (i < 2)
                    {

                    }
                    else if (line.Length < 1)
                    {
                        line += i;
                    }
                    else
                        line += ", " + i;
                }
            }
            Console.WriteLine(line);
        }
        public static void name_define(string listNames)
        {
            
            string[] names;
            names = listNames.Split(',');
            string newnameList = string.Empty;
            int x, y;
            foreach (string name in names)
            {
                string newname = String.Empty;
                x = name.Length;
                y = 0;
                for (int i = 0; i < x; i++)
                {
                    newname = name.Substring(y, 1) + newname;
                    y++;
                }
                if (newnameList.Length > 1)
                    newnameList = newnameList + ", " + newname;
                else
                    newnameList = newname;
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(newnameList);
            Console.ReadLine();
        }
    }
}
