using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Entities.PlayerEntities;
using HauntedHouse.Data.Entities.HouseEntities;
using HauntedHouse.Data.Entities.ChallengeEntities;

namespace HauntedHouse.Data.Utilities
{
    public static class GameUtilities
    {
        public static List<InGameItem> InitializePlayerStartUpItems()
        {
            string[] listOfStuff = File.ReadAllLines(@"/Users/brianlane/ElevenFiftyProjects/codingFoundations/dotNetprojects/csharpBasics/12_HauntedHouseApp/HauntedHouse.Data/InGameItems.txt");

            List<InGameItem> playerStartingItems = new List<InGameItem>();
            for (int i = 0; i < listOfStuff.Length; i++)
            {
                if(listOfStuff[i] == "|")
                {
                    var inGameItem = new InGameItem
                    {
                        ID = int.Parse(listOfStuff[++i]),
                        Name = listOfStuff[++i],
                        TimesCanBeUsed = int.Parse(listOfStuff[++i])
                    };
                    playerStartingItems.Add(inGameItem);
                }
            }
            return playerStartingItems;
        }
        public static void FoundPistolCartrage(int roundValue, Player player)
        {
            player.LoadPlasmaPistol(roundValue);
        }
        public static void TellTheStory(string storySection)
        {
            System.Console.WriteLine(storySection);

        }
        public static void DisplayFloorChallengInfo(HauntedHouse.Data.Entities.HouseEntities.HauntedHouse _house)
        {
            foreach (Floor floor in _house.FloorsInHouse)
            {
                foreach (Challenge fChallenge in floor.Challenges)
                {
                    System.Console.WriteLine(fChallenge.ChallengeDescription);
                }
            }
        }
    }
}