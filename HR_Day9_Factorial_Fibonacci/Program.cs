using System;
using System.IO;

namespace HR_Day9_Factorial
{
    class Program
    {
        static int factorial(int n)
        {
            if(n > 1)
            {
                 return n*factorial(n - 1);
            }
            return 1;

        }
        static int fibonacci(int num)
        {
            /* Recrusive calling solution
            if(num == 0 )
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            return fibonacci(num - 1) + fibonacci(num - 2); */

            /* Looping solution */
            int temp = 0;
            int num1 = 0, num2 = 1;
            Console.WriteLine("Fibonacci series");
            for (int i = 0; i <= num; i++)
            {
                if (i > 1)
                {
                    temp = num1 + num2;
                    num1 = num2;
                    num2 = temp;
                }
                else
                {
                    temp = temp + i;
                }

                Console.WriteLine(temp);
            }
            return temp;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);
            Console.WriteLine("Factorial result {0}",result);
            textWriter.WriteLine(result);
            
            Console.WriteLine("Fibonacci result {0} ",fibonacci(n));
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
