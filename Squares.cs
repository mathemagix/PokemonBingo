using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBingo
{
    public static class Squares
    {
        public static List<string> BasicCatches = new List<string>()    //Pick 5   
        {
            "Catch a Pidgey",
            "Catch a Rattata",
            "Catch a Spearow",
            "Catch a Nidoran♂",
            "Catch a Weedle",
            "Catch a Kakuna",
            "Catch an Ekans",
            "Catch a Geodude",
            "Catch a Zubat",
            "Catch an Oddish",            
            "Catch a Mankey",

        };

        public static List<string> RareCatches = new List<string>()     //Pick 3 
        {
            "Catch a Nidoran♀",
            "Catch a Pikachu",
            "Catch a Caterpie",
            "Catch a Metapod",
            "Catch a Jigglypuff",
            "Catch a Clefairy",
            "Catch a Paras",
            "Catch an Abra",
            "Complete an in-game trade"
        };

        public static List<string> Handicaps = new List<string>()   //Pick 3
        {
            "Release your starter",
            "Get confused by a Zubat in Mt. Moon",
            "Have one of your pokemon die of poison",
            "Lose twice to your rival",
            "Black out and respawn in Pallet Town",
            "Use 5 pokeballs on the same pokemon",
            "Take Charmander as your starter",
        };

        public static List<string> Rivals = new List<string>()  //Pick 2
        {
            "Beat your rival in Oak's Lab",
            "Beat your rival on Route 22",
            "Beat your rival on Nugget Bridge",
            "Beat your rival at S.S. Anne"
        };

        public static List<string> GymBattles = new List<string>()  //Pick 2
        {
            "Beat Brock",
            "Beat Misty",
            "Beat Lt. Surge",
        };

        public static List<string> Evolutions = new List<string>()  //Pick 3
        {
            "Get a Beedrill or Butterfree",
            "Use the moon stone to evole a pokemon",
            "Evolve a pokemon besides your starter",
            "Have 3 evolved pokemon in your party",
            "Stop a pokemon from evolving",
        };

        public static List<string> Trainers = new List<string>()    //Pick 3
        {
            "Beat a trainer on the S.S. Anne",
            "Defeat a trainer using the same pokemon as you",
            "Defeat a gym trainer",
            "Defeat all 3 bug catchers in Viridian Forest",
            "Defeat all 4 rockets in Mt. Moon",
            "Defeat all 3 Lass's on Route 3"
        };

        public static List<string> Other = new List<string>()   //Pick 4
        {
            "Level a pokemon to 20",
            "Field a full party of 6 pokemon",
            "Teach two TMs to the same pokemon",
            "Collect your fossil in Mt. Moon",
            "Buy Magikarp",
            "Have 12 catch entries in your pokedex",
            "Have 5000 pokedollars",
            "Claim your bike"
        };
    }
}
