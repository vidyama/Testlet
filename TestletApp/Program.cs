using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestletApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = CreateItems();
            Testlet testlet = new Testlet("A10", items);

            var randomItems = testlet.Randomize();
            foreach(Item item in randomItems)
            {
                Console.WriteLine(item.ItemId);

            }
            Console.ReadLine();
        }
      static  List<Item> CreateItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item { ItemId = "Item1", ItemType = ItemTypeEnum.Operational });
            items.Add(new Item { ItemId = "Item2", ItemType = ItemTypeEnum.Operational });
            items.Add(new Item { ItemId = "Item3", ItemType = ItemTypeEnum.Operational });
            items.Add(new Item { ItemId = "Item4", ItemType = ItemTypeEnum.Operational });
            items.Add(new Item { ItemId = "Item5", ItemType = ItemTypeEnum.Operational });
            items.Add(new Item { ItemId = "Item6", ItemType = ItemTypeEnum.Operational });
            items.Add(new Item { ItemId = "Item7", ItemType = ItemTypeEnum.Pretest });
            items.Add(new Item { ItemId = "Item8", ItemType = ItemTypeEnum.Pretest });
            items.Add(new Item { ItemId = "Item9", ItemType = ItemTypeEnum.Pretest });
            items.Add(new Item { ItemId = "Item10", ItemType = ItemTypeEnum.Pretest });

            return items;
        }
    }
}
