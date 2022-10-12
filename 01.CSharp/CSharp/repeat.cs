using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class repeat
    {
        static void Main_d(String[] args)
        {
            // 반복문
            int count = 5;
            string answer;

            while (count > 0)
            {
                Console.WriteLine("Hello World!");
                count--;

            }

            do // 꼭 한번은 실행해야한다면 쓰는문 잘 안쓰긴함;;
            {
                Console.WriteLine("세상은 안녕인가요?");
                answer = Console.ReadLine();
            } while (answer != "y");

            Console.WriteLine("감사합니다?");

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Hello World!");
            }


            //break, continue

            int num = Convert.ToInt32(Console.ReadLine()); //1 2 3 5 7 11 13 17 23 29 31 37 41

            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("소수입니다!");
            else
                Console.WriteLine("소수가 아닙니다!");


            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                    continue;//조건이 맞으면 위로 다시 올라감
                
                Console.WriteLine($"3으로 나뉘는 숫자 : {i}");
            }

        }
    }
}
