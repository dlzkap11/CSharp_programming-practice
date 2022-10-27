using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    //객체지향 -> 은닉성
    class Knight
    {
        protected int hp;

        public int Hp //get, set이 꼭 다 있어야할 필요는 없음
        {
            get { return hp; }
            set { hp = value; }
        }


        public int Mp { get; set; } = 100; //초기화 문법
        /*
        private int _mp;
        public int GetMp() { return _mp; }
        public void SetMp(int value) { this._mp = value; }
        */

        //Getter Get함수
        public int GetHp() { return hp; }

        //Setter Set함수
        public void SetHp(int hp) { this.hp = hp; }

    }

    class Property
    {
        static void Main(string[] args)
        {
            //프로퍼티
            Knight knight = new Knight();
            knight.SetHp(100);

            knight.Hp = 100; //넣어줄 때

            int hp = knight.Hp; //가져올때

            knight.Mp = 100;
            int mp = knight.Mp;
        }
        
    }
}
