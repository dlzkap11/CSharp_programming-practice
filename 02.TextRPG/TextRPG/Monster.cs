using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton =3
    }
    class Monster : Creature
    {
        protected MonsterType type;

        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(10, 2);
        }
    }
    class Orc: Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(15, 4);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetInfo(12, 5);
        }
    }
}
