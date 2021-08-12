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
            faction herofaction = faction.Divergent;
            int killCount = 0;


            Console.Title = "Divergent";
            Console.WriteLine("The world you knew is now gone. It has been destroyed. The only thing left is a town surrounded by a large cement wall created by our founders to keep everyone safe. We have been divided into five factions.");
            System.Threading.Thread.Sleep(9000);
            Console.WriteLine(Environment.NewLine + "The factions are based on personality, virtue, and strength. Each group possesses certain qualities they mutually value and excel at. The factions are called Abnegation (selfless), Erudite (intellectual), Dauntless (brave), Candor (honest), and Amity (peaceful).");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine(Environment.NewLine + "There is an evil dictator determind to take over all five factions. You must help us defeat her.");
            System.Threading.Thread.Sleep(5000);
           
            Console.WriteLine(Environment.NewLine + "What's your name?");
            Divergent = Console.ReadLine();
           

            bool factionMenu = true;
            do
            {

                Console.WriteLine("You are Divergent but you must choose a faction to fight with:\n" +
                    "1)Abnegation- They possess the ability to fight and to protect themselves but have never experienced battle\n" +
                    "2)Erudite- They are cunning but not the strongest\n" +
                    "3)Dauntless- They have been taught to fight but can be out witted\n" +
                    "4)Candor- Honesty does not get you far in the battlefield\n" +
                    "5)Amity- They can protect themselves but usually choose peace over battle\n");
        

                ConsoleKey factionChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (factionChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        herofaction = faction.Abnegation;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        herofaction = faction.Erudite;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        herofaction = faction.Dauntless;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        herofaction = faction.Candor;
                        factionMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        herofaction = faction.Amity;
                        factionMenu = false;
                        break;

                    default:
                        Console.WriteLine($"{factionChoice} is not valid. Please choose again");
                        break;
                }



            } while (factionMenu);

            Console.Clear();
            Console.WriteLine($"Thank you, {Divergent} you are now fighting with {herofaction}\n You will gain thier skill set..");
            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("To get the the evil dictator we must get past all of her guards. You'll need a weapon");
            System.Threading.Thread.Sleep(3000);

            weapon railGun = new weapon("Lightweight with very small rounds that shoot extremely fast", 5, 1, 4);
            Player divergent = new Player("The Savior", 70, 10, 50, 50, herofaction, railGun);

            bool exit = false;
            do
            {
                Console.WriteLine(room.ChooseRoom());
                badGuys mindControlled = new badGuys("One of the Dauntless soldiers minds have been taken over! They are now on the evil dictators side", 30, 2, 10, 10, 1, "The new Dauntless enemy starts to attack", 5 );

                Guards trainedSoldier = new Guards("One of the evil dictators trained soldiers", 30, 2, 10, 10, 1, "", 5, new Random().Next(2) == 1 ? true : false);

                Guards evilDictator = new Guards("The evil Dictator! We must defeat her!", 50, 20, 20, 1, 6, "She is ", 6, new Random().Next(3) == 2 ? true : false);


                badGuys[] badGuys =
                {
                    mindControlled,mindControlled,trainedSoldier,trainedSoldier,trainedSoldier,evilDictator
                };
                Random rand = new Random();
                int index = rand.Next(badGuys.Length);
                badGuys badguy = badGuys[index];
                Console.WriteLine("In this room you see a " + badguy.Name + "!");

                bool reload = false;
                do
                {
                    Console.Title = $"Life: {divergent.Life}  Bad guys killed: {killCount}";

                    Console.WriteLine("What do you do?:\n" +
                        "A) Attack\n" +
                        "F) Flee\n" +
                        "V) View Stats\n" +
                        "M) View Bad Guy Stats\n");

                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (userChoice)
                    {

                        case ConsoleKey.A:
                            combat.Battle(divergent, badguy);
                            if (badguy.Life <= 0)
                            {
                               
                                Console.WriteLine("You killed the" + badguy.Name + "!");
                          

                                reload = true;
                                System.Threading.Thread.Sleep(1700);
                                killCount++;
                            }
                            break;

                        case ConsoleKey.F:
                            
                            Console.WriteLine("You chose to run, you are now factionless");
                            System.Threading.Thread.Sleep(1700);
                            Console.WriteLine("You no longer have a home or a reason to fight. You will spend the rest" +
                                "of your days scavanging for food and shelter.");
                            System.Threading.Thread.Sleep(1700);
                            Console.WriteLine("Game Over");
                            exit = true;
                            break;

                        case ConsoleKey.V:
                            Console.WriteLine(divergent);

                            break;

                        case ConsoleKey.M:
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
            Console.WriteLine("GAME OVER!");





        }
    }
}






