using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //정수
            //byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트-21억~21억), long(8바이트 짱 많음)
            //sbyte(1바이트 -128~127), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong(8바이트 양수만)

            //형식변환
            // 1. 크기가 다른 경우
            int a = 0x0fffffff;
            short b = (short)a;

            short x = 100;
            int y = b;


            // 2. 크기는 같은데 부호가 다를 경우
            byte h = 254;
            sbyte sh = (sbyte)h;
            // underflow, overflow
            // 0xFF = 0b11111111 = -1

            // 3. 소수
            float f = 3.1313f;
            double d = f;


            //10진수
            // 0 1 2 3 4 5 6 7 8 9


            //2진수
            // 0 1  0b로 2진수임을 표현
            // 0b00 0b01 0b10 0b11 0b100 0b101 0b110 ...
            // 0b10001111 = 0x8f


            //16진수
            // 0~9 a b c d e f 0x로 16진수임을 표현
            // 0x00 0x01 0x02 ...0x0f 0x10 0x11 ...0x1f 0x2f


            int hp;
            long id;//아이디계열은 long으로 만들어두는게 편함
            byte attack = 0;

            //bool형은 1바이트 (참/거짓)
            bool check;

            check = true;
            check = false;

            //소수
            //float(4바이트) double(8바이트)
            /*
            float f = 3.14f;
            double d = 3.14;
            */
            //char(2바이트) string
            char c = 'a';
            string str = "aa";


            attack--; //최소값을 넘어가면 언더플로우로 인해 255가 출력됨


          
            Console.WriteLine("Hello Numver !{0}", attack);
        }
    }
}
