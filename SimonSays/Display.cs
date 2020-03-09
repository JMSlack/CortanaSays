using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Console = Colorful.Console;


namespace SimonSays
{
    public class Display
    {

        public int DisplayMenu(int exit)
        {
            List<string> menu = new List<string>() { "Start Game", "HighScore", "Controls", "Exit Game"};
            int currentTask = 0;
            bool menuLoop = false;

            do
            {


                for (int i = 0; i < menu.Count; i++)
                {
                    if (i == currentTask)
                    {
                        Console.BackgroundColor = Color.White;
                        Console.ForegroundColor = Color.Black;
                        Console.SetCursorPosition(54, (21 + i));
                        System.Console.WriteLine($"{menu[i]}");
                        Console.BackgroundColor = Color.Black;
                        Console.ForegroundColor = Color.White;

                    }
                    else
                    {
                        Console.SetCursorPosition(54, (21 + i));
                        System.Console.WriteLine(menu[i]);

                    }
                }

                    var keyInfo = Console.ReadKey(true).Key;
                    switch (keyInfo)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (currentTask != 0)
                                {
                                    currentTask--;
                                }
                                else
                                {

                                    currentTask = 3;

                                }
                                break;

                            }
                        case ConsoleKey.DownArrow:
                            {
                                if (currentTask != 3)
                                {
                                    currentTask++;
                                }
                                else
                                {

                                    currentTask = 0;

                                }
                            break;

                            }
                        case ConsoleKey.Enter:
                            {
                                if (currentTask == 0)
                                {
                                Console.Clear();
                                menuLoop = true;
                                exit = 0;
                                }
                                else if (currentTask == 1)
                                {
                                exit = 1;
                                }
                                else if (currentTask == 2)
                                {
                                menuLoop = true;
                                exit = 2; 
                                }
                                else if(currentTask == 3)
                                {
                                menuLoop = true;
                                exit = 3;
                                }
                                break;

                            }


                    }
                
            } while (!menuLoop);
            return exit;
        }



        public void DisplayName()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteAscii("    CORTANA SAYS", Color.FromArgb(214, 170, 255));
        }
       public void DisplayTiles()
        {
            Console.SetCursorPosition(54, 12);
            Console.BackgroundColor = Color.DarkRed;
            Console.WriteLine("    ");
            Console.SetCursorPosition(54, 13);
            Console.BackgroundColor = Color.DarkRed;
            Console.WriteLine("    ");
            Console.ResetColor();
            Console.SetCursorPosition(60, 12);
            Console.BackgroundColor = Color.DarkGreen;
            Console.WriteLine("    ");
            Console.SetCursorPosition(60, 13);
            Console.BackgroundColor = Color.DarkGreen;
            Console.WriteLine("    ");
            Console.ResetColor();
            Console.SetCursorPosition(54, 15);
            Console.BackgroundColor = Color.DarkBlue;
            Console.WriteLine("    ");
            Console.SetCursorPosition(54, 16);
            Console.BackgroundColor = Color.DarkBlue;
            Console.WriteLine("    ");
            Console.ResetColor();
            Console.SetCursorPosition(60, 15);
            Console.BackgroundColor = Color.DarkGoldenrod;
            Console.WriteLine("    ");
            Console.SetCursorPosition(60, 16);
            Console.BackgroundColor = Color.DarkGoldenrod;
            Console.WriteLine("    ");
            Console.ResetColor();
        }

        public void IlluminateTile(int tile)
        {
            if (tile == 0)
            {
                Console.SetCursorPosition(54, 12);
                Console.BackgroundColor = Color.Red;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 13);
                Console.BackgroundColor = Color.Red;
                Console.WriteLine("    ");
                Console.Beep(330, 400);
                Thread.Sleep(200);
                Console.SetCursorPosition(54, 12);
                Console.BackgroundColor = Color.DarkRed;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 13);
                Console.BackgroundColor = Color.DarkRed;
                Console.WriteLine("    ");
                Thread.Sleep(100);


            }
            else if (tile == 1)
            {
                Console.SetCursorPosition(60, 12);
                Console.BackgroundColor = Color.Green;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 13);
                Console.BackgroundColor = Color.Green;
                Console.WriteLine("    ");
                Console.Beep(220, 400);
                Thread.Sleep(200);
                Console.SetCursorPosition(60, 12);
                Console.BackgroundColor = Color.DarkGreen;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 13);
                Console.BackgroundColor = Color.DarkGreen;
                Console.WriteLine("    ");
                Thread.Sleep(100);

            }
            else if (tile == 2)
            {
                Console.SetCursorPosition(54, 15);
                Console.BackgroundColor = Color.Blue;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 16);
                Console.BackgroundColor = Color.Blue;
                Console.WriteLine("    ");
                Console.Beep(277, 400);
                Thread.Sleep(200);
                Console.SetCursorPosition(54, 15);
                Console.BackgroundColor = Color.DarkBlue;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 16);
                Console.BackgroundColor = Color.DarkBlue;
                Console.WriteLine("    ");
                Thread.Sleep(100);


            }
            else
            {
                Console.SetCursorPosition(60, 15);
                Console.BackgroundColor = Color.Yellow;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 16);
                Console.BackgroundColor = Color.Yellow;
                Console.WriteLine("    ");
                Console.Beep(392, 400);
                Thread.Sleep(200);
                Console.SetCursorPosition(60, 15);
                Console.BackgroundColor = Color.DarkGoldenrod;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 16);
                Console.BackgroundColor = Color.DarkGoldenrod;
                Console.WriteLine("    ");
                Thread.Sleep(100);


            }
        }
       public void UserIlluminate(int tile)
       {
                if (tile == 0)
                {
                Console.SetCursorPosition(54, 12);
                Console.BackgroundColor = Color.Red;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 13);
                Console.BackgroundColor = Color.Red;
                Console.WriteLine("    ");
                Console.Beep(330, 400);
                Console.SetCursorPosition(54, 12);
                Console.BackgroundColor = Color.DarkRed;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 13);
                Console.BackgroundColor = Color.DarkRed;
                Console.WriteLine("    ");

            }
                else if (tile == 1)
            {
                Console.SetCursorPosition(60, 12);
                Console.BackgroundColor = Color.Green;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 13);
                Console.BackgroundColor = Color.Green;
                Console.WriteLine("    ");
                Console.Beep(220, 400);
                Console.SetCursorPosition(60, 12);
                Console.BackgroundColor = Color.DarkGreen;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 13);
                Console.BackgroundColor = Color.DarkGreen;
                Console.WriteLine("    ");
            }
                else if (tile == 2)
                {
                Console.SetCursorPosition(54, 15);
                Console.BackgroundColor = Color.Blue;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 16);
                Console.BackgroundColor = Color.Blue;
                Console.WriteLine("    ");
                Console.Beep(277, 400);
                Console.SetCursorPosition(54, 15);
                Console.BackgroundColor = Color.DarkBlue;
                Console.WriteLine("    ");
                Console.SetCursorPosition(54, 16);
                Console.BackgroundColor = Color.DarkBlue;
                Console.WriteLine("    ");

            }
                else
                {
                Console.SetCursorPosition(60, 15);
                Console.BackgroundColor = Color.Yellow;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 16);
                Console.BackgroundColor = Color.Yellow;
                Console.WriteLine("    ");
                Console.Beep(392, 400);
                Console.SetCursorPosition(60, 15);
                Console.BackgroundColor = Color.DarkGoldenrod;
                Console.WriteLine("    ");
                Console.SetCursorPosition(60, 16);
                Console.BackgroundColor = Color.DarkGoldenrod;
                Console.WriteLine("    ");

            }
            }

        public void ControlMarkings()
        {
            Console.ForegroundColor = Color.White;
            Console.BackgroundColor = Color.Black;
            Console.SetCursorPosition(55, 12);
            System.Console.WriteLine("I");
            Console.SetCursorPosition(61, 12);
            System.Console.WriteLine("O");
            Console.SetCursorPosition(55, 15);
            System.Console.WriteLine("K");
            Console.SetCursorPosition(61, 15);
            System.Console.WriteLine("L");
            Console.SetCursorPosition(50, 27);
            Console.WriteLine("Press 'E' to Exit");
 

        }

    }
}
