using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Entities.EnemyEntities;

namespace HauntedHouse.Data.Entities.ChallengeEntities
{
    public class BossChallenge : Challenge
    {
        public Boss Boss { get; set; } = new Boss();
    }
}