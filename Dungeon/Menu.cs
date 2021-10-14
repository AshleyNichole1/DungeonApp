using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Dungeon
{
    class Menu
    {
        static void Main(string[] args)
        {

            string Divergent;
            Faction herofaction = Faction.Yourself;
            int killCount = 0;


            Console.Title = "Divergent";
            Console.WriteLine("The world you knew is now gone. It has been destroyed. The only thing left is a town surrounded by a large cement wall created by our founders to keep everyone safe. We have been divided into five factions.");
            Console.WriteLine("");
        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Explosion.GetExplosion());

            Console.ResetColor();
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("The factions are based on personality, virtue, and strength. Each group possesses certain qualities they mutually value and excel at. The factions are called Abnegation (selfless), Erudite (intellectual), Dauntless (brave), Candor (honest) and Amity (peaceful).");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine(Environment.NewLine + "There is an evil dictator determind to take over all five factions. You must help us defeat her.");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(Environment.NewLine + "What's your name?");
            Divergent = Console.ReadLine();
            Console.Clear();


            bool factionMenu = true;
            do
            {

                Console.WriteLine(Divergent + " you are Divergent meaning you possess qualities of all factions but you will need back up. Choose a faction to fight beside." + Environment.NewLine);
                System.Threading.Thread.Sleep(2500);

                Console.WriteLine(
                    "1)Abnegation- They possess the ability to fight and to protect themselves but have never experienced battle\n" +
                    "2)Erudite- They are cunning and brave but not the strongest\n" +
                    "3)Dauntless- They have been taught to fight and defend but can be out witted\n" +
                    "4)Candor- Their honesty, though noble, does not get them far in the battlefield\n" +
                    "5)Amity- They have learned to protect and fight for themselves but usually choose peace over battle\n" +
                    "6)Divergent- On your own.");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Soldiers.GetSoldiers());
                Console.ResetColor();


                ConsoleKey factionChoice = Console.ReadKey().Key;


                switch (factionChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.A:
                        herofaction = Faction.Abnegation;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.E:
                        herofaction = Faction.Erudite;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D:
                        herofaction = Faction.Dauntless;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.C:
                        herofaction = Faction.Candor;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        herofaction = Faction.Amity;
                        factionMenu = false;
                        break;


                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        herofaction = Faction.Yourself;
                        factionMenu = false;
                        break;

                    default:
                        Console.WriteLine($"{factionChoice} is not valid. Please choose again");
                        break;
                }
                

            } while (factionMenu);

          
            Console.Clear();
            Console.WriteLine($"Thank you, {Divergent} you are now fighting by {herofaction}\n");
            System.Threading.Thread.Sleep(1000);

            Weapon myWeapon = new Weapon();

            bool weaponMenu = true;
            do
            {
                Console.WriteLine("To get to the evil dictator we must get past all of her guards. You'll need a weapon:");
                System.Threading.Thread.Sleep(2500);

                Console.WriteLine(
                    "1)The rail gun\n" +
                    "2)A Glass Shard\n" +
                    "3)Your Bare Hands\n" +
                    "4)A Large Sword\n");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(Weapons.GetWeapons());
                Console.ResetColor();

                ConsoleKey weaponChoice = Console.ReadKey().Key;


                switch (weaponChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        myWeapon.Name = "A Rail Gun";
                        myWeapon.MaxDamage = 5;
                        myWeapon.MinDamage = 2;
                        weaponMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        myWeapon.Name = "A Glass Shard";
                        myWeapon.MaxDamage = 12;
                        myWeapon.MinDamage = 4;
                        weaponMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        myWeapon.Name = "Your Bare Hands";
                        myWeapon.MaxDamage = 10;
                        myWeapon.MinDamage = 6;
                        weaponMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        myWeapon.Name = "A Large Sword";
                        myWeapon.MaxDamage = 15;
                        myWeapon.MinDamage = 2;
                        weaponMenu = false;
                        break;

                    default:
                        Console.WriteLine($"{weaponChoice} is not valid. Please choose again");
                        break;



                }
            } while (weaponMenu);

           
            Console.Clear();
            Console.WriteLine(Divergent + " fighting with " + myWeapon + Environment.NewLine + "Fighting by " + herofaction);
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("There is a large building, in the building are guards protecting multiple rooms but we know the Evil Dictator is hiding in one. Let's go in and find her.." + Environment.NewLine);

            System.Threading.Thread.Sleep(2500);
            
            Player divergent = new Player(Divergent, 70, 10, 50, 50, herofaction, myWeapon);


            bool exit = false;
            do
            {
               
             
                Console.WriteLine(Room.ChooseRoom());
                BadGuys mindControlled = new BadGuys("One of the Dauntless soldiers whose mind has been taken over", 55, 20, 30, 40, 8, "This soldier was once with the Dauntless faction. The evil Dictator has taken over their mind", 2);

                Guards trainedSoldier = new Guards("One of the evil dictators trained soldiers", 55, 15, 30, 25, 8, "These soldiers are mindless followers who do not realize the evil dictators true intentions.", 2);

                Guards evildictator = new Guards("The Evil Dictator", 65, 12, 25, 45, 9, "The Dictator has lost her mind, she will stop at nothing for ultimate power and control.", 2);


                BadGuys[] badGuys =
                {
                    mindControlled,mindControlled,trainedSoldier,trainedSoldier,trainedSoldier
                };
             
                BadGuys badguy;
               
                if (killCount == 2)
                {
                    badguy = evildictator; 
                }
               
                else
                {
                    Random rand = new Random();
                    int index = rand.Next(badGuys.Length);
                    badguy = badGuys[index];
                }

                    Console.WriteLine(badguy.Name);
               
            
                bool reload = false;
                do
                {
                    Console.Title = $"Life: {divergent.Life}  Bad guys killed: {killCount}";
                    Console.WriteLine();
                    Console.WriteLine("What do you do?:\n" +
                        "A) Attack\n" + 
                        "R) Run\n" +
                        "S) Stats\n" +
                        "B) Bad Guy Stats\n" +
                        "Esc) EXIT \n");

                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (userChoice)
                    {

                        case ConsoleKey.A:
                            War.Battle(divergent, badguy);
                            
                            if (badguy.Life <= 0)
                            {
                                                          

                                Console.WriteLine("You killed " + badguy.Name + "!");


                                reload = true;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("The room has been cleared.");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                killCount++;



                            }
                            break;

                  

                        case ConsoleKey.R:

                            Console.WriteLine("You chose to run, you are now factionless");
                            System.Threading.Thread.Sleep(1700);
                            Console.WriteLine("You no longer have a home or a reason to fight. You will spend the rest " +
                                "of your days scavanging for food and shelter.");
                            Console.WriteLine();

                            exit = true;
                            break;

                        case ConsoleKey.S:
                            Console.WriteLine(divergent);

                            break;

                        case ConsoleKey.B:
                            Console.WriteLine(badguy);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You have chosen to exit the game.");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Ivalid Response.");
                            break;
                    }

                    if (badguy.Life <= 0 && killCount >= 3)
                    {
                        Console.WriteLine("You've defeated the Evil Dictator!");
                        Console.WriteLine();
                        exit = true;
                    }                    


                    if (divergent.Life < 1)
                    {
                        Console.WriteLine($"You have been killed by {badguy.Name}!");
                        Console.WriteLine();
                        exit = true;
                    }
                               
                    //UX needs improvement 
                    //Need to adjust stats.               
                    //I want to add ascii art

                } while (!reload && !exit);


            } while (!exit);

            Console.WriteLine();
            Console.WriteLine("FIN");
            


        }
    }
}






