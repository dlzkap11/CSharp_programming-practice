using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    class Lambda
    {
        static List<Item> _items = new List<Item>();

        static void Main(string[] args)
        {
            //Lambda : 일회용 함수를 만드는데 사용하는 문법

            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Rare });
            _items.Add(new Item() { ItemType = ItemType.Amulet, Rarity = Rarity.Uncommon });

        }
    }
}
