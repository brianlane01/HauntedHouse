using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HauntedHouse.Data.Entities.PlayerEntities;
using HauntedHouse.Data.Entities.ChallengeEntities;

namespace HauntedHouse.Data.Entities.HouseEntities
{
    public class HauntedHouse
    {
        public HauntedHouse()
        {
            Name = "BoonVille Farms";
            Address = "1357 Evil Lane";
            City = "MonsterVille Indiana";
            Player = new Player("Buddy");
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Player Player { get; set; }
        public List<Floor> FloorsInHouse { get; set; } = new List<Floor>();

        public override string ToString()
        {
            var str = $"ID: {ID}\n"+
                $"Name: {Name}\n"+ 
                $"Address: {Address}\n"+ 
                $"City: {City}\n"+ 
                $"Player: {Player.Name}\n"+ 
                "------ Floors in House------\n";
            foreach (Floor floor in FloorsInHouse)
            {
                str+= $"FloorId: {floor.ID}\n"+
                        $"Floor Name: {floor.Name}\n"+
                        "======== Floor Challeng =======\n";
                foreach (Challenge floorChallenge in floor.Challenges)
                {
                    str += $"Floor Challenge ID: {floorChallenge.ID}\n"+
                            $"Floor Challenge Description: {floorChallenge.ChallengeDescription}";
                    foreach (string task in floorChallenge.ChallengeTasks)
                    {
                        str+= $"{task}";
                    }
                    str += $"Floor Challenge Complete: {floorChallenge.IsComplete}";
                }
            }
                return str;
        }
    }
}