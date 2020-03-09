using System;
using System.Collections.Generic;
using System.Drawing;

using System.Threading;


namespace SimonSays
{
    class Program
    {
    

        static void Main(string[] args)
        {
          

            Program p = new Program();
            p.GameEngine();            
        }

        public void GameEngine()
        {
            //List<int> compTile = new List<int>();
            //int listLength = compTile.Count;
            Console.CursorVisible = false;
            bool replay = false;
            Random prng = new Random();
            Display d = new Display();
            


            Point Point1 = new Point(0, 0);
            ConsoleRectangle c = new ConsoleRectangle(117, 27, Point1, ConsoleColor.Cyan);
            bool menuLoop = false;

            int scoreCounter = 0;

            Display m = new Display();

            do
            {
                Console.Clear();
                m.DisplayName();
                //c.DrawBox();
                d.DisplayTiles();
                int exit = m.DisplayMenu(0);
                switch(exit)
                {
                    case 0: {

                        do
                        {
                            List<int> compTile = new List<int>();
                            int listLength = compTile.Count;
                            Console.CursorVisible = false;
                            bool gameLoop = false;
                            scoreCounter = 0;

                            Console.SetCursorPosition(50, 27);
                            Console.WriteLine("Press 'E' to Exit");
                            m.DisplayName();
                            //c.DrawBox();
                            d.DisplayTiles();

                            do
                            {
                                Thread.Sleep(400);
                                foreach (int i in compTile)
                                {
                                    Thread.Sleep(200);
                                    d.IlluminateTile(i);

                                }

                                int tile = prng.Next(0, 4);

                                if (tile == 0)
                                {
                                    d.IlluminateTile(tile);
                                    compTile.Add(tile);


                                }
                                else if (tile == 1)
                                {
                                    d.IlluminateTile(tile);
                                    compTile.Add(tile);

                                }
                                else if (tile == 2)
                                {
                                    d.IlluminateTile(tile);
                                    compTile.Add(tile);

                                }
                                else
                                {
                                    d.IlluminateTile(tile);
                                    compTile.Add(tile);

                                }

                                listLength = compTile.Count;
                                for (int i = 0; i < listLength; i++)  // Waiting for User Response
                                {
                                    int listTile = compTile[i];

                                    switch (listTile)
                                    {
                                        case 0:
                                            {
                                                var userInput = Console.ReadKey(true).Key;
                                                if (userInput == ConsoleKey.I)
                                                {
                                                    d.UserIlluminate(listTile);

                                                    break;

                                                }
                                                else
                                                {
                                                    Console.Beep(700, 1000);
                                                    i = listLength;
                                                    gameLoop = true;

                                                    break;
                                                }

                                            }
                                        case 1:
                                            {
                                                var userInput = Console.ReadKey(true).Key;
                                                if (userInput == ConsoleKey.O)
                                                {
                                                    d.UserIlluminate(listTile);

                                                    break;

                                                }
                                                else
                                                {
                                                    Console.Beep(700, 1000);
                                                    i = listLength;
                                                    gameLoop = true;
                                                    break;
                                                }
                                            }
                                        case 2:
                                            {
                                                var userInput = Console.ReadKey(true).Key;
                                                if (userInput == ConsoleKey.K)
                                                {
                                                    d.UserIlluminate(listTile);

                                                    break;

                                                }
                                                else
                                                {
                                                    Console.Beep(700, 1000);
                                                    i = listLength;
                                                    gameLoop = true;
                                                    break;
                                                }
                                            }
                                        case 3:
                                            {
                                                var userInput = Console.ReadKey(true).Key;
                                                if (userInput == ConsoleKey.L)
                                                {
                                                    d.UserIlluminate(listTile);

                                                    break;

                                                }
                                                else
                                                {
                                                    Console.Beep(700, 1000);
                                                    i = listLength;
                                                    gameLoop = true;
                                                    break;
                                                }
                                            }
                                        case 4:
                                            {
                                                var userInput = Console.ReadKey(true).Key;
                                                if (userInput == ConsoleKey.E)
                                                {
                                                    break;
                                                }
                                                break;
                                            }
                                    }

                                }



                                scoreCounter++;


                            } while (!gameLoop);

                            Console.SetCursorPosition(47, 23);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"GAME OVER! Your Score: {scoreCounter - 1}");
                            Console.SetCursorPosition(47, 24);
                            Console.WriteLine("Play Again?: Y / N");

                            var playAgain = Console.ReadKey(true).Key;
                            switch (playAgain)
                            {
                                case ConsoleKey.Y:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                case ConsoleKey.N:
                                    {
                                        replay = true;
                                        break;
                                    }


                            }
                        } while (!replay);
                        break;
                    }
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            m.DisplayName();                           
                            d.DisplayTiles();                   
                            d.ControlMarkings();
                            var userInput = Console.ReadKey(true).Key;
                            if (userInput == ConsoleKey.E)
                            {
                               
                                break;

                            }

                            break;
                        }
                    case 3:
                        {
                            menuLoop = true;
                            break;
                        }

                }

            } while (!menuLoop);
        }

    }
}
