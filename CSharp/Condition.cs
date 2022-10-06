using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Condition
    {
        static void Main_c(String[] args)
        {
            int hp = 100;
            bool isDead = (hp <= 0);

            int choice = 0; // 0:가위 1:바위 2:보 3:치트키

            if (isDead)
            {
                Console.WriteLine("You are dead!");
            }
            else
            {
                Console.WriteLine("You are alive!");
            }


            if (choice == 0)
            {
                Console.WriteLine("가위입니다.");
            }
            else if(choice == 1)
            {
                Console.WriteLine("바위입니다.");
            }
            else if(choice == 2)
            {
                Console.WriteLine("보입니다.");
            }
            else
            {
                Console.WriteLine("치트키입니다.");
            }



            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("보입니다.");
                    break;
                case 3:
                    Console.WriteLine("치트키입니다.");
                    break;
                default:
                    Console.WriteLine("망했습니다.");
                    break;
            }


            //삼항연산자

            int num = 25;
            bool isPair = ((num % 2) == 0 ? true : false);




        }
    }
}
