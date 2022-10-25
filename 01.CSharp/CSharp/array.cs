using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class array
    {
        static void Main_3(string[] args)
        {
            //배열
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            //int[] scores = new int[] { 10, 20, 30, 40, 50 };
            //int[] scores ={ 10, 20, 30, 40, 50 };
            //취향차이

            /*
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;
            */
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }


        }
    }
}
