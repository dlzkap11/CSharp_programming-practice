using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar

    //Observer Pattern
{
    class Event//InputManager
    {
        public delegate void OnInputKey(); //함수자체를 인자로 보내고 싶을 때 delegate를 사용하고
        public event OnInputKey InputKey; // 외부에서 남용되는 것을 방지하기위해 event를 사용한다


        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                //모두한테 알려준다
                InputKey();
            }
        }

    }
}
