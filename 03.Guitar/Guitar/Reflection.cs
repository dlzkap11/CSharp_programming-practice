using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Reflection
    {

        class Important : System.Attribute
        {
            string message;
            public Important(string message) { this.message = message; }
        }

        class Monster
        {
            [Important ("very important")] //컴퓨터가 런타임중에 볼 수 있는 일종의 주석?

            //[SerializeField] private로 선언된 함수를 유니티로 볼 수 있음

            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }
        }

        static void Main(string[] args)
        {
            // Reflection : X-Ray
            Monster monster = new Monster();
            Type type = monster.GetType();


           var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";


               var attributes = field.GetCustomAttributes();

                Console.WriteLine(access + field.FieldType.Name + field.Name);
            }

        }
    }
}
