using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Delegate
    {
        //콜백방식 
        //UI와 게임로직은 최대한 분리하는게 좋음

        delegate int OnClicked(); //하나의 형식
        //delegate -> 함수 자체를 인자로 넘겨주는 그런 형식
        //반환 : int 입력 : void
        //OnClicked 가 delegate 형식의 이름이다


        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
        {
            //함수를 호출();
            clickedFunction();
        }
        
        static int TestDelegate()
        {
            Console.WriteLine("으아악");
            return 0;
        }
        static int TestDelegate2()
        {
            Console.WriteLine("으아악2");
            return 0;
        }


        static void Main(string[] args)
        {
            //delegate 대리자

            //내부 돌아가는 구조
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2; //체이닝


            ButtonPressed(clicked/**/);
            ButtonPressed(TestDelegate/**/);

            clicked();
        }

    }
}
