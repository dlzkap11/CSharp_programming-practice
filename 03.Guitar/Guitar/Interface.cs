using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{

    abstract class Monster //abstract class 추상 클래스
    {
        public abstract void Shout(); //개념적으로만 존재
 
    }

    interface IFlyable
    {
       void Fly();
    }

    class Orc : Monster
    {
        public override void Shout()
        {
            Console.WriteLine("록타르 오가르!");
        }
    }

    class FlyableOrc : Orc, IFlyable //다중 상속이 제한되기때문에 인터페이스를 사용
    {
        public void Fly() //꼭 만들어줘야함
        {

        }
    }

    class Skeleton : Monster //오버라이딩 Shout()를 꼭 써야함
    {
        //public override void Shout()
       //{
       //    Console.WriteLine("으아앙");
       // }
    }

    class SkeletonOrc : Orc, Skeleton //C#은 다중 상속이 안됨 c++은 가능
    {

    }

   


    class Interface
    {
        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            Monster monster = new Monster(); //추상이라 생성이 안댐;;

            IFlyable flyable = new FlyableOrc();

            DoFly(flyable);

        }
    }
}
