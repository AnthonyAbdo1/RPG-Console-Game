using System;
using Gaming_Test.Locations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Test;
using AnthonysGame;


namespace Gaming_Test
{
    public class Player
    {
        //General Player Non-Offensive Stats//
        public int Hp { get; set; }
        public int Defense { get; set; }
        public int MagicDefence { get; set; }
        public int FireDamageDefense { get; set; }
        public int FrostDamageDefense { get; set; }
        public int ShockDamageDefense { get; set; }
        public int PoisonDefense { get; set; }

        //General Player Offensive Stats//
        public int AttackDamage { get; set; }
        public int MagicDamage { get; set; }
        public int FireDamage { get; set; }
        public int FrostDamage { get; set; }
        public int ShockDamage { get; set; }
        public int PoisonDamage { get; set; }

        //General Player Stats
        public string Name { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public int Gold { get; set; }
        public int HealthPotionCount { get; set; }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////

            //Check Player Stats Actions//

        public void CheckOffensiveStats(Player player)
        {
            Console.WriteLine(player.AttackDamage);
            Console.WriteLine(player.MagicDamage);
            Console.WriteLine(player.FireDamage);
            Console.WriteLine(player.FrostDamage);
            Console.WriteLine(player.ShockDamage);
            Console.WriteLine(player.PoisonDamage);
        }
        public void CheckDefenseStats(Player player)
        {
            Console.WriteLine(player.Hp);
            Console.WriteLine(player.Defense);
            Console.WriteLine(player.FireDamageDefense);
            Console.WriteLine(player.FrostDamageDefense);
            Console.WriteLine(player.ShockDamageDefense);
            Console.WriteLine(player.PoisonDefense);
            
        }

        public void CheckGold(Player player)
        {
            Console.WriteLine(player.Gold);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////

            //Examine Monster Action//
        public void ExamineMonster(Player player, Monster monster)
        {
            Console.WriteLine(monster.Description);
        }

        public int AttackMonster(Player player, Monster monster)
        {
            var TotalPlayerDamage = player.AttackDamage + player.MagicDamage +
            player.PoisonDamage + player.FireDamage + player.FrostDamage + player.ShockDamage;
            var Outcome = monster.Hp - TotalPlayerDamage;
            monster.Hp = Outcome;
            return monster.Hp;
        }

        public int DrinkPotion(Player player, Potions potions)
        {
            var currentHealth = player.Hp + potions.Effect;
            player.HealthPotionCount--;
            return currentHealth;
        }
    }
}
