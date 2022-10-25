using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class List
    {
        static void Main_1(string[] args)
        {
            //List <- 동적 배열
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)              
                list.Add(i);

            //삽입 삭제
            list.Insert(2, 999);//인덱스의 값을 삽입

            list.Remove(999);//값을 삭제
            list.RemoveAt(0);//인덱스의 값을 삭제

            list.Clear();//전체삭제


            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            foreach(int num in list)
                Console.WriteLine(num);
        }
    }
}
