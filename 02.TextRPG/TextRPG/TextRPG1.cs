using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    //객체 (OOP Object Oriented Programming) - 은닉성, 상속성, 다형성

    // Archer
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die...

    class Player //부모(기반) 클래스
    {

        //접근 한정자
        // pulbic(공용) protected(가족공유) private(자기 자신만)
        static public int counter = 1; //오로지 1개만 존재
        public int id;
        private int hp;
        protected int attack;

        public void SetHP(int hp)
        {
            this.hp = hp;
        }

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }
    //오버로딩(함수 이름의 재사용) != 오버라이딩(다형성을 이용하는것)

    class Mage : Player//자식(파생) 클래스
    {
        public int mp;
        public override void  Move()
        {
            base.Move();//부모기능을 쓰고 더 추가하고 싶을때
            Console.WriteLine("Mage 이동!");
        }
    }

    class Archer : Player
    {

    }
    //ref참조
    class Knight : Player
    {
        public Knight()//생성자
        {
            id = counter;
            counter++;

            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this()
        {
            base.SetHP(100);
            Console.WriteLine("int 생성자 호출");
        }



        public Knight Clone()//사실상 새로운 객체
        {
            Knight knight = new Knight();
            knight.SetHP(100);
            knight.attack = attack;
            return knight;
        }
        public override void Move()
        {
            Console.WriteLine("Kinght 이동!");
        }



    }

    //복사
   /* struct Mage
    {
        public int hp;
        public int attack;
    }
   */
    class TextRPG1
    {
        static void EnterGame(Player player)
        {
            player.Move();

            Mage mage = (player as Mage);  //as를 더 추천하는편 
            if (mage != null)
            {
                mage.mp = 10;
            }
            /*
            bool isMage = (player is Mage);
            if (isMage)
            {
                Mage mage = (Mage)player;
                mage.mp = 10;
            }
            */
        }

        static void Main(string[] args)
        {

            Knight knight = new Knight(); //객체 생성
            Mage mage = new Mage();


            // Mage 타입 -> Player 타입
            // Player 타입 -> Mage 타입?
            /*
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;
            */

            EnterGame(knight);
            EnterGame(mage);


            //Knight knight3 = new Knight(50);
            //Knight knight2 = knight.Clone();

        }
    }
}
