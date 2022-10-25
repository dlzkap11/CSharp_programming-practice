using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Practice
    {
        static int GetHighestScore(int[] scores)//가장 높은 점수
        {
            int result = 0;
            /*
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {                
                        if (result > scores[i])
                            continue;
                        result = scores[i];
                    }
                    else// if (scores[i] <= scores[j]) 
                    {
                        if (result > scores[i])
                            continue;
                        result = scores[j];
                    }
                   
                }
   
            }
            */
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > result)
                    result = scores[i];
            }

            return result;
        }

        static int GetAverageScore(int[] scores)//점수의 평균
        {

            int result = 0;
            
            for (int i = 0; i < scores.Length; i++)
            {
                result += scores[i];
            }
            /*
            foreach(int list in scores)
            {
                result += list; // 0 + scores[0]+[1]+[2]+[3]+[4]
            }
            */
            return result/scores.Length;
        }
        static void GetIndex0f(int[] scores) //값을 찾는 함수
        {
            
            Console.WriteLine("찾으려는 값을 입력하시오!");
            int find = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < scores.Length; i++)
            {
                if (find == scores[i])
                {
                    Console.WriteLine(find + "을(를) 찾았습니다!");
                }

            }
  
        }

        static void Sort(int[] scores)//작은값순으로 정렬
        {
            int num = 0;
            for (int i = 0; i < scores.Length - 1; i++)
            {
                for (int j = 1; j < scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {

                        num = scores[j];
                        scores[j] = scores[i];
                        scores[i] = num;
                    }
                    else
                    {

                        num = scores[i];
                        scores[i] = scores[j];
                        scores[j] = num;
                    }
   

                }

            }

            for (int i = 0; i < scores.Length; i++)
                Console.Write(scores[i] + " ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[5] { 20, 50, 30, 10, 40 };

            Console.WriteLine(GetHighestScore(scores));
           // Console.WriteLine(GetAverageScore(scores));
            //GetIndex0f(scores);
           //Sort(scores);
            

        }
    }
}
