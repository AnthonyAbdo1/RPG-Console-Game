using Gaming_Test;
using System;
using System.Collections.Generic;
using Gaming_Test.Locations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnthonysGame
{

    public class Program
    {



        static void Main(string[] args)
        {
            //Intro To Game...Character Selection//
            Console.WriteLine("Press any button to start!");
            Console.ReadLine();
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("As options are presented to you the game will progress based on");
            Console.WriteLine("the choices you make.....Press Enter to continue.");
            Console.ReadLine();
            Console.WriteLine("You will have a list of options to choose from.");
            Console.WriteLine("You will begin by choosing your players class.");
            Console.ReadLine();
            Console.WriteLine("Your options are Fighter, Ranger, and Mage.");
            Console.WriteLine("Type one of those in to select the class you want.");



            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////
            var player = new Player();

            //Class Selection//

            while (1 == 1)
            {
                var classSelect = Console.ReadLine();

                if (classSelect == "Fighter")
                {
                    //Fighter Player Stats//
                    player.Hp = 130;
                    player.Defense = 5;
                    player.MagicDefence = 2;
                    player.FireDamageDefense = 2;
                    player.FrostDamageDefense = 2;
                    player.ShockDamageDefense = 2;
                    player.PoisonDefense = 2;
                    //Base Player Attack Stats//
                    player.AttackDamage = 20;
                    player.MagicDamage = 0;
                    player.FireDamage = 0;
                    player.FrostDamage = 0;
                    player.ShockDamage = 0;
                    player.PoisonDamage = 0;
                    //Base Player General Stats//

                    player.Class = "Fighter";
                    player.Gold = 0;
                    player.HealthPotionCount = 0;
                    player.Description = "A fierce worrior skilled in melee combat.";
                    Console.WriteLine("You chose the Fighter Class");
                    break;
                }

                else if (classSelect == "Ranger")
                {
                    //Ranger Player Stats//
                    player.Hp = 110;
                    player.Defense = 2;
                    player.MagicDefence = 2;
                    player.FireDamageDefense = 2;
                    player.FrostDamageDefense = 2;
                    player.ShockDamageDefense = 2;
                    player.PoisonDefense = 2;
                    //Base Player Attack Stats//
                    player.AttackDamage = 6;
                    player.MagicDamage = 0;
                    player.FireDamage = 0;
                    player.FrostDamage = 0;
                    player.ShockDamage = 0;
                    player.PoisonDamage = 1;
                    //Base Player General Stats//

                    player.Class = "Ranger";
                    player.Gold = 0;
                    player.HealthPotionCount = 0;
                    player.Description = "A fast and agile archer with a keen eye and steady arm";
                    Console.WriteLine("You chose the Ranger Class");
                    break;
                }

                else if (classSelect == "Mage")
                {
                    //Fighter Player Stats//
                    player.Hp = 90;
                    player.Defense = 2;
                    player.MagicDefence = 6;
                    player.FireDamageDefense = 3;
                    player.FrostDamageDefense = 3;
                    player.ShockDamageDefense = 3;
                    player.PoisonDefense = 2;
                    //Base Player Attack Stats//
                    player.AttackDamage = 1;
                    player.MagicDamage = 4;
                    player.FireDamage = 1;
                    player.FrostDamage = 1;
                    player.ShockDamage = 1;
                    player.PoisonDamage = 0;
                    //Base Player General Stats//

                    player.Class = "Mage";
                    player.Gold = 0;
                    player.HealthPotionCount = 0;
                    player.Description = "A wise intelligent mage skilled in destructive spells";
                    Console.WriteLine("You chose the Mage Class");
                    break;

                }

                else
                {
                    Console.WriteLine("Invalid Selection");
                    Console.WriteLine("Please type Fighter, Ranger, or Mage");

                }



            }

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            //Low level Wilderness Monsters//
            var WildernessAnimals = new List<Monster> {

                new Monster(){Name = "Giant Rat", Hp = 30, AttackDamage = 3, Gold = 3, Description = "An ugly, huge Rat"},
                new Monster(){Name = "Wild Dog", Hp = 35, AttackDamage = 4, Gold = 3, Description = "A rabid wild Dog"},
                new Monster(){Name = "Wolf", Hp = 40, AttackDamage = 5, Gold = 3 , Description = "A hungry angry Wolf"},
                new Monster(){Name = "Mountain Lion", Hp = 60, AttackDamage = 7, Gold = 5, Description = "Here kitty kitty."},
                new Monster(){Name = "Bear", Hp = 70, AttackDamage = 10, Gold = 8 , Description = "A big brown ball of mean fur"},
                new Monster(){Name = "Angry Moose", Hp = 75, AttackDamage = 12, Gold = 8, Description = "A large Moose with huge antlers!"},

            };

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            //Low level Dungeon Monsters//
            var DungeonMonsters = new List<Monster> {

                new Monster(){Name = "Skeleton", Hp = 30, AttackDamage = 5 , Gold = 3 , Description = "Walking Bag o Bones"},
                new Monster(){Name = "Zombie", Hp = 60, AttackDamage = 6, Gold = 5, Description = "Smells Lovely"},
                new Monster(){Name = "Giant Bat", Hp = 50, AttackDamage = 6, Gold = 5, Description = "Giant Rat with Wings"},
                new Monster(){Name = "Goblin", Hp = 40, AttackDamage = 7, Gold = 10, Description = "An ugly tiny Goblin"},
                new Monster(){Name = "Goblin WarLord", Hp = 60, AttackDamage = 8, Gold = 15, Description = "A giant ugly Goblin"},
                new Monster(){Name = "Baby Troll", Hp = 60, AttackDamage = 9, Gold = 10, Description = "Grows into a giant monster"}


            };


            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            //Low level Cave Monsters//
            var CaveMonsters = new List<Monster> {

                new Monster(){Name = "Bandit" , Hp = 60, AttackDamage = 10, Gold = 5, Description = "An armed rogue"},
                new Monster(){Name = "Attack Dog", Hp = 40, AttackDamage = 5, Gold = 5, Description = "A hound trained to attack on command"},
                new Monster(){Name = "Cave Goblin", Hp = 60, AttackDamage = 10, Gold = 10, Description = "More powerfull than a common goblin"},
                new Monster(){Name = "War Deserter", Hp = 70 , AttackDamage = 10 , Gold = 10, Description = "An exile in hiding"},
                new Monster(){Name = "Crazed Madman", Hp = 40 , AttackDamage = 6 , Gold = 10, Description = "A crazy person"}

            };


            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            //Tutorial//
            Console.WriteLine("Great! Now what is your name?...Press Enter to Continue");
            var nameInput = Console.ReadLine();
            player.Name = nameInput;

            Console.WriteLine("Welcome " + player.Name);
            Console.WriteLine("Please allow me a moment to explain the instructions");
            Console.WriteLine("Press enter when you wish to move forewards when wording is displayed");
            Console.ReadLine();
            Console.WriteLine("This also applies when you are doing almost anything");
            Console.WriteLine("If no prompt is givin pressing Enter is a good idea");
            Console.ReadLine();

            Console.WriteLine("There are generally two modes in this game");
            Console.WriteLine("The first is EXPLORATION MODE and COMBAT MODE");
            Console.ReadLine();
            Console.WriteLine("In both of these modes your options are presented after each Prompt");
            Console.ReadLine();
            Console.WriteLine("Thats all! Press Enter to Start Your Adventure!!!!");
            Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////



            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            var room = new List<Locations>
            {
                new Locations(){Name = "Cistern", Description = "A endless sewer and water system. Dangerous aquatic animals dwell here."},
                new Locations(){Name = "Dead Forest", Description = "A ash filled and bone dry forest full of dead woods and jagged rocks."},
                new Locations(){Name = "Ice Cave", Description = "A frozen and frigid cave."},
                new Locations(){Name = "Lizard Man Camp", Description = "A camp of hostile lizard people"},
                new Locations(){Name = "Endless Staircase", Description = "A endless set of stairs and small rooms "},
                new Locations(){Name = "Abandon Town", Description = "A ghost town once full of people"},
                new Locations(){Name = "Massive Library", Description = "A library so large it has no forseable end"},
                new Locations(){Name = "Animal Sanctuary", Description = "A abandon zoo overun with animals"},
            };
            

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            var potionList = new List<Potions> {

               new Potions(){Name = "Healing Potion", Effect = player.Hp + 20 },
               new Potions(){Name = "Attack Boost", Effect = player.AttackDamage + 15},
               new Potions(){Name = "Magic Boost", Effect = player.MagicDamage + 15},
               new Potions(){Name = "Defense Boost", Effect = player.Defense + 15}

            };

            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////

            while (1 == 1)
            {
                //Code for selecting Random Monster//
                var random = new Random();
                int rdnMonster = random.Next(WildernessAnimals.Count);
                var MonsterHealth = WildernessAnimals[rdnMonster].Hp;

                ///////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////

                //Start of Game//

                Console.WriteLine("You have just woke from a deep and disturbing sleep.");
                Console.WriteLine("You have no idea where you are or how you got there.");
                Console.ReadLine();
                Console.WriteLine("You get up from the cold stone ground and look around");
                Console.ReadLine();
                Console.WriteLine("It is dark and damp, but feint rays of light can be seen ahead.");
                Console.ReadLine();
                Console.WriteLine("As you step ahead you enter a small room that is empty aside from a statue.");
                Console.ReadLine();
                Console.WriteLine("In the hand of the statue is a small iron dagger.");
                Console.WriteLine("Its holding it out as if to offer it to you");

                while(1 == 1)
                {
                    Console.WriteLine("What shall you do?...Enter 'A' to take it or 'B' to reject it");
                    
                    var Destiny = Console.ReadLine();

                    if (Destiny == "A")
                    {
                        Console.WriteLine("You take the dagger from the statues hand and suddenly the room begins");
                        Console.WriteLine("to change! The walls form into a single hallway lighted by torches.");
                        break;
                    }

                    else if (Destiny == "B")
                    {
                        Console.WriteLine("Suddenly the statue moves and grips the dagger in it hand");
                        Console.ReadLine();
                        Console.WriteLine("With one swift movement it plunges the blade into your heart...");
                        Console.ReadLine();
                        Console.WriteLine("The statue simply says..Unworthy..");
                        Console.WriteLine("All turns to black........");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    else
                    {
                        Console.WriteLine("Invalid Command");
                        continue;
                    }
                }

                while (1 == 1)
                {
                    Console.WriteLine("As you walk down the hallway you catch the scent of something cooking.");
                    Console.ReadLine();
                    Console.WriteLine("The scent becomes stronger the farther down the hall you go.");
                    Console.ReadLine();
                    Console.WriteLine("You rush twards the directions of the sent hoping to find someone who can help you.");
                    Console.ReadLine();
                    Console.WriteLine("You see a wooden door with light eminating from behind it.");
                    Console.ReadLine();
                    Console.WriteLine("How will you proceed?");
                    

                    while (1 == 1)
                    {
                        Console.WriteLine("Enter 'A' to knock on the door or 'B' to smash it down!");
                        var decision = Console.ReadLine();

                        if (decision == "B")
                        {
                            Console.WriteLine("You burst through the door!");
                            Console.ReadLine();
                            Console.WriteLine("As you look around it seems someone has been living here");
                            Console.WriteLine("A bed, some pots and pans, as well as glass bottles are ");
                            Console.WriteLine("litered all around the room.");
                            Console.ReadLine();
                            break;
                        }

                        else if (decision == "A")
                        {
                            Console.WriteLine("You get no answer...");
                            Console.ReadLine();
                            continue;
                        }
                    }

                    break;
                }

                while (1 == 1)
                {
                    Console.WriteLine("Suddenly you feel your being watched...");
                    Console.ReadLine();
                    Console.WriteLine("You turn around and standing before you is a short hairy man");
                    Console.ReadLine();
                    Console.WriteLine("He is armed but doesnt apear to be hostile");
                    Console.ReadLine();
                    Console.WriteLine("What will you do?...Enter 'A' to attack him or 'B' to talk to him.");

                    var decision = Console.ReadLine();

                    if (decision == "A")
                    {
                        Console.WriteLine("You bring raise the dagger in your hand and thrust it twards the man");
                        Console.ReadLine();
                        Console.WriteLine("As the dagger draws closer to the man he raises his arm");
                        Console.ReadLine();
                        Console.WriteLine("He grips your arm and with inhuman strength starts to squeeze");
                        Console.WriteLine("cuasing you to drop the dagger.");
                        break;
                    }

                    else if (decision == "B")
                    {
                        Console.WriteLine("You say Hello...");
                        Console.ReadLine();
                        Console.WriteLine("The man doesnt respond");
                        Console.ReadLine();
                       
                        break;
                    }
                }
                Console.WriteLine("Suddenly he smiles revealing his missing teeth");
                Console.ReadLine();
                Console.WriteLine("He erupts in a raspy throaty luaghter!");
                Console.ReadLine();
                Console.WriteLine("PETE:'Hello! The names Pete!'");
                Console.ReadLine();
                Console.WriteLine("PETE:'Welcome to the Labyrinth'");
                Console.ReadLine();
                Console.WriteLine("PETE: 'Let me guess. You dont know where you are or how you got here?'");
                Console.ReadLine();
                Console.WriteLine("PETE:'Its the same with everyone else who arives here'");
                Console.ReadLine();
                Console.WriteLine("PETE:'Well..Ill keep this simple'");
                Console.ReadLine();
                Console.WriteLine("PETE:'People come here. I help them get on their feet'");
                Console.ReadLine();
                Console.WriteLine("PETE:'Everyone iv met and sent off has yet to come back though..'");
                Console.ReadLine();
                Console.WriteLine("PETE:'They either escaped or died..'");
                Console.ReadLine();
                Console.WriteLine("PETE:'As for me I like it here. Nobody to bother me.'");
                Console.ReadLine();
                Console.WriteLine("PETE:'You can head off in any direction from here.'");
                Console.WriteLine("PETE:'or you can stick around and chat'");
                Console.ReadLine();
                Console.WriteLine("PETE:'I have a space for your things if you plan to stick around.'");
                Console.ReadLine();
                Console.WriteLine("PETE:'I also have things to sell but I doubt you have any money on you.'");
                Console.ReadLine();
                Console.WriteLine("PETE:'Well anyway, your free to do as you wish'");
                Console.ReadLine();

                //Start of Game//
                while (1 == 1)
                {
                    Console.WriteLine("What will you do? 'A = Travel'..'B = Talk to Pete'");
                    while (1 == 1)
                    {
                        var decision = Console.ReadLine();

                        //Travel//
                        if (decision == "A")
                        {
                            while(1 == 1)
                            {

                            }
                        }

                        //Pete
                        else if (decision == "B")
                        {

                        }

                        else
                        {
                            Console.WriteLine("Invalid Command");
                            Console.ReadLine();
                            return;
                        }

                    }
                }

                

                






                //Start of Combat//

                Console.WriteLine("A " + WildernessAnimals[rdnMonster].Name + " has apeared");

                while (1 == 1)
                {

                    Console.WriteLine("What will you do?");

                    var moveOption = Console.ReadLine();

                    if (moveOption == "Attack")
                    {
                        Console.WriteLine("You attack the " + WildernessAnimals[rdnMonster].Name);
                        Console.WriteLine("The " + WildernessAnimals[rdnMonster].Name + "'s Hp is now " + player.AttackMonster(player, WildernessAnimals[rdnMonster]));

                        if (WildernessAnimals[rdnMonster].Hp <= 0)
                        {
                            Console.WriteLine("The " + WildernessAnimals[rdnMonster].Name + " is dead");
                            Console.ReadLine();
                            break;
                        }

                        else if (player.Hp <= 0)
                        {
                            Console.WriteLine("You have died...Game Over");
                        }

                        else
                        {
                            Console.WriteLine("The " + WildernessAnimals[rdnMonster].Name + " attacks. Your Hp is now " + WildernessAnimals[rdnMonster].AttackPlayer(WildernessAnimals[rdnMonster], player));
                            Console.ReadLine();
                            continue;
                        }
                    }

                    else if (moveOption == "DrinkPotion")
                    {
                        Console.WriteLine("Which Potion do you wish to drink?");
                        var potionDrink = Console.ReadLine();
                        if (potionDrink == "Health")
                        {
                            if (player.HealthPotionCount > 0)
                            {
                                player.DrinkPotion(player, potionList[0]);

                                Console.WriteLine("You drink the potion. Your health is now " + player.Hp);
                                Console.WriteLine("The " + WildernessAnimals[rdnMonster].Name + " attacks. Your Hp is now " + WildernessAnimals[rdnMonster].AttackPlayer(WildernessAnimals[rdnMonster], player));
                                Console.ReadLine();
                                continue;

                            }

                            else
                            {
                                Console.WriteLine("You have no Health Potions to drink");
                                continue;
                            }
                        }
                    }

                    else if (moveOption == "Examine")
                    {
                        Console.WriteLine(WildernessAnimals[rdnMonster].Description);
                        Console.ReadLine();
                        continue;
                    }
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////


                Console.ReadLine();


            }
        }
    }
}





