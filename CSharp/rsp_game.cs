using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class rsp_game
    {
        enum Choice // 열거형
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main_c(String[] args)
        {
            //0: 가위 1: 바위 2: 보
            //const 상수로 고정된 값
            /*
            const int rock = 1;
            const int paper = 2;
            const int scissors = 0;
            */
            //rock = 3; 오류남

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신은 보입니다.");
                    break;
                default:
                    Console.WriteLine("당신은 망했습니다.");
                    break;
            }
            /*
            switch (aiChoice)
            {
                case scissors:
                    Console.WriteLine("컴퓨터는 가위입니다.");
                    break;
                case rock:
                    Console.WriteLine("컴퓨터는 바위입니다.");
                    break;
                case paper:
                    Console.WriteLine("컴퓨터는 보입니다.");
                    break;

            }
            
            //0: 가위 1: 바위 2: 보

            // 0 2 | 1 0 | 2 1| 승
            // 0 1 | 1 2 | 2 0| 패
            // 0 0 | 1 1 | 2 2| 무승부


            if (choice == aiChoice)
            {
                Console.WriteLine("무승부!");
            }
            else if (choice == scissors && aiChoice == paper || choice == rock && aiChoice == scissors || choice == paper && aiChoice == rock)
            {
                Console.WriteLine("우승!");
            }
            else if (choice == scissors && aiChoice == rock || choice == rock && aiChoice == paper || choice == paper && aiChoice == scissors)
            {
                Console.WriteLine("패배!");
            }
            */

        }
    }
}
