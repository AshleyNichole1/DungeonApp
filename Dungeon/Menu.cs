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
            //System.Threading.Thread.Sleep(7000);
            Console.WriteLine(Environment.NewLine + "The factions are based on personality, virtue, and strength. Each group possesses certain qualities they mutually value and excel at. The factions are called Abnegation (selfless), Erudite (intellectual), Dauntless (brave), Candor (honest), and Amity (peaceful).");
            //System.Threading.Thread.Sleep(11000);
            Console.WriteLine(Environment.NewLine + "There is an evil dictator determind to take over all five factions. You must help us defeat her.");
            //System.Threading.Thread.Sleep(5000);

            Console.WriteLine(Environment.NewLine + "What's your name?");
            Divergent = Console.ReadLine();



            bool factionMenu = true;
            do
            {

                Console.WriteLine(Divergent + " you are Divergent meaning you possess qualities of all factions but you must choose one faction to fight with" +
                    "\nChoose wisely......");
                //System.Threading.Thread.Sleep(7500);
                Console.Clear();
                Console.WriteLine(
                    "1)Abnegation- They possess the ability to fight and to protect themselves but have never experienced battle\n" +
                    "2)Erudite- They are cunning and brave but not the strongest\n" +
                    "3)Dauntless- They have been taught to fight and defend but can be out witted\n" +
                    "4)Candor- Their honesty, though noble, does not get them far in the battlefield\n" +
                    "5)Amity- They have learned to protect and fight for themselves but usually choose peace over battle\n" +
                    "6)Divergent- On your own.");



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

            Console.WriteLine(herofaction);
            //System.Threading.Thread.Sleep(1500);

            Console.Clear();
            Console.WriteLine($"Thank you, {Divergent} you are now fighting with {herofaction}\n");
            //System.Threading.Thread.Sleep(5000);


            Weapon myWeapon = new Weapon();

            bool weaponMenu = true;
            do
            {
                Console.WriteLine("To get to the evil dictator we must get past all of her guards. You'll need a weapon:");
                //System.Threading.Thread.Sleep(4500);

                Console.WriteLine(
                    "1)The rail gun\n" +
                    "2)A Glass Shard\n" +
                    "3)Your Bare Hands\n" +
                    "4)A Large Sword\n" );


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

            Console.WriteLine(myWeapon);
            //System.Threading.Thread.Sleep(1500);

            Console.Clear();
            Console.WriteLine(Divergent + " with " + myWeapon + "fighting by " + herofaction);
            //System.Threading.Thread.Sleep(3000);


          
            Player divergent = new Player(Divergent, 70, 10, 50, 50, herofaction, myWeapon);
            //System.Threading.Thread.Sleep(10000);
            Console.Clear();

            bool exit = false;
            do
            {
             
                Console.WriteLine(Room.ChooseRoom());
                BadGuys mindControlled = new BadGuys("One of the Dauntless soldiers whose mind has been taken over", 30, 2, 10, 10, 1, "The new Dauntless enemy starts to attack", 5);

                Guards trainedSoldier = new Guards("One of the evil dictators trained soldiers", 30, 2, 10, 10, 1, "The mindless soldier attacks", 5);

                Guards evilDictator = new Guards("The evil Dictator", 50, 20, 20, 1, 6, "She is strong and will stop at nothing", 6);


                BadGuys[] badGuys =
                {
                    mindControlled,mindControlled,trainedSoldier,trainedSoldier,trainedSoldier,evilDictator
                };
                Random rand = new Random();
                int index = rand.Next(badGuys.Length);
                BadGuys badguy = badGuys[index];
                Console.WriteLine(badguy.Name);

               

                bool reload = false;
                do
                {
                    Console.Title = $"Life: {divergent.Life}  Bad guys killed: {killCount}";

                    Console.WriteLine("What do you do?:\n" +
                        "A) Attack\n" + 
                        "R) Run\n" +
                        "S) Stats\n" +
                        "B) Bad Guy Stats\n");//view bad guys stats is messed up (lists bad guy and says "you've done damage")

                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (userChoice)
                    {

                        case ConsoleKey.A:
                            War.Battle(divergent, badguy);
                            if (badguy.Life <= 0)
                            {

                                //figure out how to change the name of the badguy once you've attacked

                                Console.WriteLine("You killed " + badguy.Name + "!");


                                reload = true;
                                //System.Threading.Thread.Sleep(4000);
                                Console.WriteLine("The room has been cleared, there's no time to waste we need to move.");
                                //System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                killCount++;
                            }
                            break;

                        case ConsoleKey.R:

                            Console.WriteLine("You chose to run, you are now factionless");
                            //System.Threading.Thread.Sleep(1700);
                            Console.WriteLine("You no longer have a home or a reason to fight. You will spend the rest " +
                                "of your days scavanging for food and shelter.");
                            //System.Threading.Thread.Sleep(1700);

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
                    if (divergent.Life < 1)
                    {
                        Console.WriteLine($"You have been killed by {badguy.Name}!");
                        exit = true;
                    }



                } while (!reload && !exit);

            } while (!exit);
            Console.WriteLine("Game Over");





        }
    }
}






