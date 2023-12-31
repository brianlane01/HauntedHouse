using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HauntedHouse.Data.Entities.PlayerEntities
{
    public class InGameItem
    {
        public InGameItem()
        {
            
        }
        public InGameItem(int id, string name, int timesCanBeUsed = 2)
        {
            ID = id;
            Name = name;
            TimesCanBeUsed = timesCanBeUsed;
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public int TimesCanBeUsed { get; set; }
        public bool IsUseable
        {
            get
            {
                return (TimesCanBeUsed > 0) ? true : false;
            }
        }
    }
}