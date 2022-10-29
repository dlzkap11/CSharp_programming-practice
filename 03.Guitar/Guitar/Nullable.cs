using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Nullable
    {
        class Monster
        {
            public int id { get; set; }
        }

        static int Find()
        {
            return 0;
        }

        static Monster FindMonster(int id)
        {
            // for()
            // return monster;

            return null;
        }
        static void Main(string[] args)
        {
            //Nullable -> Null + able
            int? number = null;


            int c = (number != null) ? number.Value : 0;//삼항 연산자
            int b = number ?? 0;
            Console.WriteLine(b);

            //number = 3;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }
            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }


            Monster monster = null;
            if (monster != null)
            {
                int monsterId = monster.id;
            }


            // Nullable -> 형식?
            // ??
            // ?.
            int? id = monster?.id;
        }
    }
}
