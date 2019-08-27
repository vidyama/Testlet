using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestletApp
{
    public class Item

    {

        public string ItemId;

        public ItemTypeEnum ItemType;
    }

    public enum ItemTypeEnum

    {

        Pretest = 0,

        Operational = 1

    }
}
