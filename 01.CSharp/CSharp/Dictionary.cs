using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Monster
    {
        public int id;
        public Monster(int id) { this.id = id; }
    }
    class Dictionary
    {
        static void Main_2(string[] args)
        {
            List<int> list = new List<int>();

            // Hashtable
            // 메모리는 손해지만 성능은 좋아짐
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            //추가하기
            for(int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            //가져오기
            Monster mon;
            bool found = dic.TryGetValue(777, out mon);

            //삭제하기
            dic.Remove(777);
            //dic.Clear();

            //dic.Add(1, new Monster(1));
            //dic[5] = new Monster(5);
        }
    }
}
