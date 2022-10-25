using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Map
    {
        
        int[,] tiles = { 
            { 1, 1, 1, 1, 1 }, //[0,0]...
            { 1, 0, 0, 0, 1 }, //[1,0]
            { 1, 0, 1, 0, 1 }, //[2,0]
            { 1, 1, 0, 0, 1 }, //[3,0] [3,1] [3,2] [3,3] [3,4] || [3,4] [3,3] [3,2] [3,1] [3,0]
            { 1, 0, 0, 1, 1 }, //[4,0]
            { 1, 1, 1, 1, 1 }
        };
        /*
        int[,] tiles = new int[5,6]{
            { 1, 1, 1, 1, 1, 1}, //[0,0]...
            { 1, 0, 0, 0, 0, 1}, //[1,0]
            { 1, 0, 0, 0, 0, 1}, //[2,0]
            { 1, 0, 0, 0, 0, 1}, //[3,0]
            { 1, 1, 1, 1, 1, 1} //[4,0]
  
        };
        */
        public void Render()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    if (tiles[x, y] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;
        }
        public void Render_fold()//좌우대칭
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = tiles.GetLength(1) - 1; y >= 0; y--) 
                {
                    if (tiles[x, y] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;

        }
        public void Render_filp()//상하대칭
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            for (int x = tiles.GetLength(0) - 1; x >= 0; x--) 
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    if (tiles[x, y] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;

        }

        public void Render_xy()//완전 대칭
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            for (int x = tiles.GetLength(0) - 1; x >= 0; x--)
            {
                for (int y = tiles.GetLength(1) - 1; y >= 0; y--)
                {
                    if (tiles[x, y] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;

        }
    }

    class multiple_array
    {
        static void Main_1(string[] args)
        {
            int[] scrores = new int[5] { 10, 30, 40, 20, 50 };

            //2차원 배열
            int[,] arr = new int[2, 3] { 
                { 4, 5, 6 }, //[0,0] [0,1] [0,2]
                { 1, 2, 3 }  //[1,0] [1,1] [1,2]
            };
            
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[2];

            //[...]
            //[......]
            //[..]

 

            Map map = new Map();
            map.Render();

            Console.WriteLine("좌우 대칭");           
            map.Render_fold();

            Console.WriteLine("상하 대칭");
            map.Render_filp();

            Console.WriteLine("완전 대칭");
            map.Render_xy();


            arr[0, 0] = 1;
            arr[1, 0] = 1;
            // 4 5 6
            // 1 2 3

           
        }
    }
}
