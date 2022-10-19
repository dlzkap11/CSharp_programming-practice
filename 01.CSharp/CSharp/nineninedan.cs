using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class nineninedan
    {
        static int Factorial(int n)
        {
            /*
            int ret = 1;

            for (int i = 1; i <= n; i++)
            {         
                ret *= i;
            }
            return ret;
            */
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }
        static void Main_b(String[] args)
        {
            //구구단
            int result;

            for (int i = 2; i <= 9; i++)
            {      
                for (int b = 1; b <= 9; b++)
                {
                    result = i * b;
                    Console.WriteLine(i + "*" + b + "=" + result);

                }

            }

            for(int i = 5; i > 0; i--)
            {

                for (int j = 0; i > j; j++) 
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine();
            }

            int ret = Factorial(6);
            Console.WriteLine(ret);


        }
    }
}
