using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random chance = new Random();
            string latestwinner = "No one has played yet";

            Console.WriteLine("Welcome to BlackJack");
            string menuselection = "0";

            while (menuselection != "4")
            {
                Console.WriteLine("Choose an alternative");
                Console.WriteLine("1. Play BlackJack");
                Console.WriteLine("2. Show the latest winner");
                Console.WriteLine("3. Rules of the game");
                Console.WriteLine("4. Exit the program");
                Console.WriteLine("");
                menuselection = Console.ReadLine();
                Console.WriteLine();
                switch (menuselection)
                {
                    case "1":
                        int computerscore = 0;
                        int playerscore = 0;
                        Console.WriteLine("Now two cards will be drawn per player");
                        Console.WriteLine("");
                        computerscore += chance.Next(1, 11);
                        computerscore += chance.Next(1, 11);
                        playerscore += chance.Next(1, 11);
                        playerscore += chance.Next(1, 11);
                        string cardchoice = "";
                        while (cardchoice != "n" && playerscore <= 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Your score: {playerscore}");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The computer's score {computerscore}");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Want one more card? y/n");
                            Console.WriteLine("");
                            cardchoice = Console.ReadLine();

                            switch (cardchoice)
                            {
                                case "y":
                                    int newcard = chance.Next(1, 11);
                                    playerscore += newcard;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"Your new card is {newcard}");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Your total is {playerscore}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Not a valid option");
                                    Console.WriteLine("");
                                    break;
                            }
                        }

                        if (playerscore > 21)
                        {
                            string busted = "Busted";

                            for (int i = 0; i < busted.Length; i++)
                            {
                                Console.Write(busted[i]);
                                Thread.Sleep(200);
                            }
                            Console.WriteLine("");
                            break;
                        }
                        while (computerscore < playerscore && computerscore <= 21)
                        {
                            int computernewcard = chance.Next(1, 11);
                            computerscore += computernewcard;
                            string loading = ".....";

                            for (int i = 0; i < loading.Length; i++)
                            {
                                Console.Write(loading[i]);
                                Thread.Sleep(200);
                            }
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"the computer pulled a new card worth {computernewcard}");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Your score: {playerscore}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Computers score {computerscore}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");

                        if (computerscore > 21)
                        {
                            string youwon = "You won!\nEnter your name";

                            for (int i = 0; i < youwon.Length; i++)
                            {
                                Console.Write(youwon[i]);
                                Thread.Sleep(200);
                            }
                            Console.WriteLine("");
                            latestwinner = Console.ReadLine();
                        }
                        else
                        {
                            string gameover = "Game over";

                            for (int i = 0; i < gameover.Length; i++)
                            {
                                Console.Write(gameover[i]);
                                Thread.Sleep(200);
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case "2":
                        Console.WriteLine($"Latest winner: {latestwinner}");
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("Your goal is to force your computer to get more than 21 points.");
                        Console.WriteLine("You get points by drawing cards, each card has 1-10 points.");
                        Console.WriteLine("If you get more than 21 points you have lost.");
                        Console.WriteLine("Both you and your computer receive two cards at the beginning.");
                        Console.WriteLine("Then you can draw more cards until you are satisfied or get over 21.");
                        Console.WriteLine("When you're done, the computer draws cards until it has");
                        Console.WriteLine("more points than you or over 21 points.");
                        Console.WriteLine("");
                        break;
                    case "4":
                        //exit
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }

        }
    }
}
