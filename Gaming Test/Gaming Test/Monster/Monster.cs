using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Test;

namespace Gaming_Test
{
    public class Monster
    {
       
        //General Monster Non-Offensive Stats//
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

        public int AttackPlayer(Monster monster, Player player)
        {
            var TotalMonsterDamage = monster.AttackDamage + monster.MagicDamage +
            monster.PoisonDamage + monster.FireDamage + monster.FrostDamage + monster.ShockDamage;
            var Outcome = player.Hp - TotalMonsterDamage;
            player.Hp = Outcome;
            return player.Hp;
        }
    }
}

