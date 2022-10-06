using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Cal
    {
        static void Main_b(String[] args)
        {
            int hp = 100;
            int level = 50;

            // + - * / %(나머지 값 출력)
            // < <= > >= == !=

            hp++; //hp = hp +1 == hp += 1


            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);

            // && AND || OR ! NOT

            // a = 살아있는 고렙 유저인가요?
            bool a = isAlive && isHighLevel;

            // b = 살아있거나, 고렙 유저이거나 ,둘 중 하나인가요?
            bool b = isAlive || isHighLevel;

            // c = 죽은 유저인감
            bool c = !isAlive;


            //Console.WriteLine(hp);


            //비트 연산
            // << >>(각 방향으로 이진법 1을 밀어내는 연산) &(and) |(or)  ^(xor) ~(not)
            // 아이디정보를 만들어가는데 사용가능
            
            uint num = 9; //<< >> 사용시에는 왠만하면 uint로 양수만 쓰는 함수를 쓰는게 좋다

            int id = 123;
            int key = 231;

            int x = id ^ key;
            //보낼때는 x를 보내고 받은 사람은 같은 key값을 대입하여서 데이터를 좀 더 안전하게 받을 수 있음


            int y = x ^ key;
            //암호화

            Console.WriteLine(x);
            Console.WriteLine(y);
           
            num = num >> 1;

            Console.WriteLine(num);


            //연산 우선순위 보통 안외움ㄹㅇ 우선순위는 ()로 강제로 맞춰주는게 좋다
            /*
             * 1. ++ --
             * 2. * / %
             * 3. + -
             * 4. << >>
             * 5. < >
             * 6. == !=
             * 7. &
             * 8. ^
             * 9. |
             * ..
            */

            // var는 왠만하면 쓰지말기 -> 코드를 읽는데 명확하지않을 수 있음
            var num1 = 3;
            var num2 = "Hello World";


        }
    }
}
