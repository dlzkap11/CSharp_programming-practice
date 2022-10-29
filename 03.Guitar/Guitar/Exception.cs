using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class _Exception //예외 처리
    {
        class TestException : Exception //커스텀 예외처리
        {

        }
        static void TestFucn()
        {
            throw new TestException();
        }
        static void Main(string[] args)
        {
            //try catch문 유사 if else 한번 catch로 가면 다음 catch는 실행X
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b; //예외처리가 나오면 다음식은 실행되지않음

                TestFucn();

            }
            catch(DivideByZeroException e)
            {

            }
            catch(Exception e)
            {

            }
            finally //예외처리가 나와도 실행되는 문
            {
                //DB, 파일 정리 등 중요한거
            }
        }

    }
}
