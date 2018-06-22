using System;

public interface Attack { };

public class Animal:Attack
{
   public int Hp { get; set; }
   public int AttackDamage { get; set; }
   public int MagicDamage { get; set; }
   public int CriticalHit { get; set; }
   public int Defense { get; set; }
   public int MagicDefence { get; set; }
   public string Description { get; set; }
}

public class Rat : Animal
{
    
}