using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestletApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestletApp.Tests
{
    [TestClass()]
    public class TestletTests
    {
        [TestMethod()]
        public void RandomizeTest()
        {
            List<Item> items = CreateItems();
            Testlet testlet = new Testlet("A10",items);
            var test1 = testlet.Randomize();
            var test2 = testlet.Randomize();
            List<ItemTypeEnum> type = test1.Select(x => x.ItemType).Take(2).Distinct().ToList();
          
            //Checks whether 2 lists are  not same and first 2 items are pretest only

            Assert.IsTrue(!test1.SequenceEqual(test2) && !type.Contains(ItemTypeEnum.Operational));

        }

        List<Item> CreateItems()
        {
            List<Item> items = new List<Item> ();
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