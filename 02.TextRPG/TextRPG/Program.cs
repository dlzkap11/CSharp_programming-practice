using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Program
    {
        enum ClassType //직업 타입
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3//jhjkjkhl
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3//asd
        }

        struct Player //플레이어 구조체
        {
            public int hp;
            public int attack;
            //ClassType type;
        }

        struct Monster //몬스터 구조체
        {
            public int hp;
            public int attack;
        }

        static ClassType ChoiceClass() //직업 선택
        {
            ClassType choice = ClassType.None;

            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 마법사");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num) 
            {
                case 1:
                    choice = ClassType.Knight;
                    Console.WriteLine("기사를 선택하였습니다!");
                    break;

                case 2:
                    choice = ClassType.Archer;
                    Console.WriteLine("궁수를 선택하였습니다!");
                    break;

                case 3:
                    choice = ClassType.Mage;
                    Console.WriteLine("마법사를 선택하였습니다!");
                    break;

            }
            return choice;

        }

        static void CreatePlayer(ClassType choice, out Player player)
        {

            switch (choice)
            //기사(100/10) 궁수(75/12) 마법사(50/15)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }

        } //플레이어 생성

        static void CreateRandomMonster(out Monster monster) //몬스터 생성
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);

            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 나타났습니다!");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 나타났습니다!");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 나타났습니다!");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }


        }
        static void Fight(ref Player player, ref Monster monster) //전투모드
        {
            while (true)
            {
                monster.hp -= player.attack;
                if(monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine("남은 체력 : " + player.hp);
                    break;
                }

                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다!");
                    break;
                }
            }
        }

        static void EnterField(ref Player player) //필드 접속
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다!");
                //몬스터 생성
                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투를 한다");
                Console.WriteLine("[2] 마을로 도망가기");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    Random rand = new Random();

                    int randValue = rand.Next(0, 101);
                    if (randValue <= 33)//33%
                    {
                        Console.WriteLine("도망치는데 성공했습니다!");
                        break;
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }

            }           
          
        }
        static void EnterGame(ref Player player) //게임 접속
        {
           

            while (true)
            {
                Console.WriteLine("마을에 접속했습니다!");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    EnterField(ref player);
                }
                else if(input == "2")
                {
                    break;
                }
            }
           
        }

        static void Main_a(string[] args)
        {

            while (true)  
            {
                ClassType choice = ChoiceClass();
                if (choice != ClassType.None)
                {
                    //캐릭터 생성
                    Player player;

                    CreatePlayer(choice, out player);
                    Console.WriteLine("HP "+ player.hp + " Attack "+ player.attack);
                    EnterGame(ref player);

                }
                    
            }                  
        }
    }
}
