using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HauntedHouse.Data.Entities.EnemyEntities
{
    public class Boss : Enemy
    {
        public void AteRandomGhoul()
        {
            IncreaseHealth(20);
            System.Console.WriteLine($"{Name} just ate a Random Ghoul!\n" + $"Its Health is now {HealthPoints}\n");
        }
    }
}