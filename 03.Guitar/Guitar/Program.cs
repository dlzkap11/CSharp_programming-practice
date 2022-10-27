using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }
        static void Main(string[] args)
        {
            Event inputManager = new Event();
            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
            inputManager.InputKey(); //event이기 때문에 불가능
        }
    }
}
