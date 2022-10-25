using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Generic
    {
        //알아두면 인생이 편해지는 기타문법

        //Generic (일반화)
        class MyList<T> where T : Monster //where T는 Monster타입만 가능
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        class Monster//<T, K>
        {

        }

        static void Test<T>(T input)
        {

        }

        static void Main(string[] args)
        {
            //var와 object의 차이
            //var는 대충보고 아 이게 그거구나
            //object는 진짜 object타입이 되는 것 어케함 ㄷㄷ 상속때문 ㄷㄷ
            //obj는 참조타입 ,힙의 저장된 결국 이거도 잘 안쓸듯?
            /*
            var obj3 = 3;
            object obj = 3;
            object obj2 = "hello world";

            int num = (int)obj;
            string str = (string)obj2;
            */
            MyList<int> myintlist = new MyList<int>();
            MyList<short> myshortlist = new MyList<short>();

            MyList<Monster> myMonsterlist = new MyList<Monster>();
            Monster item = myMonsterlist.GetItem(0);

            Test<int>(3);
            Test<bool>(true);
        }
    }
}
