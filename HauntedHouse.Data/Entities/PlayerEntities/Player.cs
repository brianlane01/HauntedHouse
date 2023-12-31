using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Utilities; 
using HauntedHouse.Data.Entities.EnemyEntities;

namespace HauntedHouse.Data.Entities.PlayerEntities
{
    public class Player
    {
        public Player()
        {
            SetUpPlayerInitialization();
        }
        public Player(string name)
        {
            Name = name;
            SetUpPlayerInitialization();
        }
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int HealthPoints { get; set; } = 100;
        public bool IsDead 
        {
            get 
            { 
                return (HealthPoints <= 0) ? true : false;
            }
        }

        public void DecreaseHealth(int pointValue = 5)
        {
            if(HealthPoints >= 0)
            HealthPoints -= pointValue;
        }

        public void IncreaseHealth(int pointValue = 5)
        {
            if(HealthPoints > 0)
            HealthPoints += pointValue;
        }

        public void ShootPlasmaPistol(Enemy enemy, int attackPower = 15)
        {
            if(PlasmaPistol.IsUseable)
            {
                PlasmaPistol.TimesCanBeUsed--;
                System.Console.WriteLine($"You shot the Plasma Pistol at {enemy.Name}!\n"+
                                $"You Haave {PlasmaPistol.TimesCanBeUsed} bullets left!");
                                if(enemy.HealthPoints > 0)  
                                {
                                    enemy.DecreaseHealth(attackPower);
                                }
                else
                {
                    System.Console.WriteLine("Shoot I better find some bullets!!!");
                }
            }
        }

        public void LoadPlasmaPistol(int roundValue)
        {
            PlasmaPistol.TimesCanBeUsed+= roundValue;
        }
        public List<InGameItem> Items;
        private InGameItem PlasmaPistol;
        private InGameItem FlashLight;
        private InGameItem Map;
        private InGameItem Knife;
        private void SetUpPlayerInitialization()
        {
            Items = GameUtilities.InitializePlayerStartUpItems();
            Knife = Items[0];
            Map = Items[1];
            FlashLight =    Items[2];
            PlasmaPistol = Items[3];
        }

    }
}