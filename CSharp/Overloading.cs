using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Overloading
    {
        // 함수 이름의 재사용

        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static int Add(int a, int b, int c = 0)
        {
            Console.WriteLine("Add2 int 호출");
            return a + b + c;

        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }
        static void Main_g(String[] args)
        {
            int ret = Add(2, 3);
            float ret2 = Add(2.3f, 3.4f);
            Add(11, 2);

            Console.WriteLine(ret + " " + ret2);
        }
    }
}
