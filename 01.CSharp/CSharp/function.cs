using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class function
    {
        // 메소드 함수
        /*
          한정자 반환형식 이름(매개변수목록)
         {

         }
        */
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Addone(ref int number)
        {
            //number += number + 1;
            number++;
        }
        static int Addone2(int number)
        {
            return ++number;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;

        }

        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }


        static void Main_f(String[] args)
        {
            int x = 0;
            int y;

            Console.WriteLine(Add(4, 5));

            Addone(ref x); //ref X =복사(가짜) ref 0 =참조(진짜) out도 마찬가지
            Console.WriteLine(x);

            int b = Addone2(x);
            x = b;

            Console.WriteLine(x);

            int num1 = 1;
            int num2 = 2;

            Console.WriteLine(num1 + " " + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine(num1 + " " + num2);

            int result1;
            int result2;

            Divide(10, 3, out result1, out result2);

            Console.WriteLine(result1 + " " + result2);

        }
    }
}
