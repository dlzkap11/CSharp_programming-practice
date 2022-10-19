using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class String
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('z');

            // 2. 변형
            name = name + "Junior";

            string lowerCaseName = name.ToLower(); //소문자
            string upperCaseName = name.ToUpper(); //대문자
            string newName = name.Replace('r', 'l'); //단어 바꾸기

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);


        }
    }
}
