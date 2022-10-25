using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Practice_b
    {
        static int GetHighestScore(int[] scores)//가장 높은 점수
        {
            int maxValue = 0;

            foreach(int score in scores)
            {
                if (score > maxValue)
                    maxValue = score;
            }

            return maxValue;
        }

        static int GetAverageScore(int[] scores)//점수의 평균
        {
            if (scores.Length == 0)
                return 0;

            int result = 0;

            foreach(int list in scores)
            {
                result += list;
            }

          

            return result / scores.Length;
        }
        static int GetIndexOf(int[] scores, int value) //값을 찾는 함수
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                    return i;
            }


            return -1;
        }

        static void Sort(int[] scores)//작은값순으로 정렬
        {
            for (int i = 0; i < scores.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                //swap
                int temp = scores[i];             
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }

            for (int i = 0; i < scores.Length; i++)
                Console.Write(scores[i] + " ");
        }

        static void Main_1(string[] args)
        {
            int[] scores = new int[5] { 20, 50, 30, 10, 40 };

            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 10));
            Sort(scores);

            for (int i = 0; i < scores.Length; i++)
                Console.Write(scores[i] + " ");
        }
    }
}