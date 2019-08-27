using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestletApp
{
    public class Testlet

    {

        public string TestletId;

        private List<Item> Items;

        public Testlet(string testletId, List<Item> items)

        {

            TestletId = testletId;

            Items = items;

        }

        public List<Item> Randomize()
        {
            Random rnd = new Random();
            var pretestItems = Items.Where(x => x.ItemType == ItemTypeEnum.Pretest).Select(x => new { value = x, order = rnd.Next() })
            .OrderBy(x => x.order).Select(x => x.value).Take(2).ToList();

            var selectedItems = pretestItems.Select(x => x.ItemId).ToList();
            var remainingItems = Items.Where(x=>!selectedItems.Contains(x.ItemId)).Select(x => new { value = x, order = rnd.Next() })
            .OrderBy(x => x.order).Select(x => x.value).ToList();


            return pretestItems.Concat(remainingItems).ToList();
            //Items private collection has 6 Operational and 4 Pretest Items. Randomize the order of these items as per the requirement (with TDD)



        }

    }


}
