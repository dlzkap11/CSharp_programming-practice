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


        delegate bool ItemSelector(Item item);

        delegate Return MyFunc<T, Return>(T item);

        /*
        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;            
        }
        */
        static Item FindItem(ItemSelector selector)//(MyFunc<Item, bool> selector)
        {
            foreach(Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
            
        }



        static void Main(string[] args)
        {
            //Lambda : 일회용 함수를 만드는데 사용하는 문법
            

            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Rare });
            _items.Add(new Item() { ItemType = ItemType.Amulet, Rarity = Rarity.Uncommon });



            //delegate를 직접 선언하지 않아도, 이미 만들어진 함수가 존재한다.
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Action
            Func<>;
            Action<>;

            //Anonymous Function :무명 함수 or 익명 함수
            Item item = FindItem(delegate (Item items) { return items.ItemType == ItemType.Weapon; });

            //이게 람다
            Item item2 = FindItem((Item items) => { return items.ItemType == ItemType.Weapon; });

            //ㄱㄴ
            ItemSelector selector = new ItemSelector((Item items) => { return items.ItemType == ItemType.Weapon; });
            Item item3 = FindItem(selector);
        }
    }
}
