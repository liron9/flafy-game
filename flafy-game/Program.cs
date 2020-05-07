using System;
using System.Threading;
using System.Timers;
namespace flafy_game
{
    class Program
    {
        //Timer
        static System.Timers.Timer Timer;

        //This function creates pipes every 5 seconds
        static void PipesSpawn()
        {
            Timer = new System.Timers.Timer(5000);
            Timer.Elapsed += PipeMovmentWithTimer;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        static void PipeMovmentWithTimer(Object source, ElapsedEventArgs e)
        {
            Timer = new System.Timers.Timer(250);
            Timer.Elapsed += PipeMovment;
            Timer.AutoReset = true;
            Timer.Enabled = true;

        }

        static void PipeMovment(Object source, ElapsedEventArgs e)
        {   
                PipePrinter();
                xPipe--;
               // Console.SetCursorPosition(xPipe, 1);

        }


        //This function sets the size of the game
        static void windowsize()
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 180;
        }

        //This function sets the borders of the game
        static void borders()
        {
            string[] bothbarriers = new string[180];

            //bottom barrier
            for (int i = 0; i < bothbarriers.Length; i++)
            {
                Console.SetCursorPosition(i, 39);
                Console.Write("#");
            }
            //upper barrier
            for (int j = 0; j < bothbarriers.Length; j++)
            {
                Console.SetCursorPosition(j, 0);
                Console.Write("#");
            }
        }

        //This is how the pipe looks like
        static string[,] pipeView = { {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},
                                  {"|"},};

        static int[,] pipesInfo = new int[5, 2];     //the array that contains the info about the pipes  1 coloum is the random hole and the other coloum is the pipe location.
                                                     // 1 function pickes a random hole              the other function prints the pipe
        
        static int centerOfHole = 0; //the var for the funtiob below
        static int pipeCounter = 0; // a line in the pipe info array
        //This funtion pickes a random hole in a pipe
        static void RandomHole()
        {
            Random randomholeselector = new Random();             
            centerOfHole = randomholeselector.Next(4, 34);
            
            pipesInfo[pipeCounter, 0] = centerOfHole;
        }

        //This fucntion spawn one pipe with a random hole in ther
        static int xPipe = 179;
        static void PipePrinter()   // <<<< int pipe 
        {
            while (pipeCounter < 5)
            {
                RandomHole();

                for (int i = 0; i < pipeView.GetLength(1); i++)
                {
                    for (int j = 0; j < pipeView.GetLength(0); j++)
                    {

                        if (!(j <= centerOfHole + 3 && j >= centerOfHole - 3))
                        {
                            Console.SetCursorPosition(xPipe, j + 1);
                            Console.Write(pipeView[j, i]);


                        }
                    }
                }

                pipesInfo[pipeCounter, 1] = xPipe;
                pipeCounter++;
            }
            pipeCounter = 0;

        }




        //This is how the player looks like
        static string[,] player ={ { " ", " ", " ", " ", " ", " ", " ", "_", "_", "_", "_", "_", "_", " " },
                                   { " ", "_", "_", " ", " ", " ", "|", " ", "o", " ", " ", " ", "o", "|" },
                                   { " ", " ", " ", "|", "-", "-", "|", " ", " ", " ", "^", " ", " ", "|" },
                                   { " ", "‾", "‾", " ", " ", " ", "|", " ", " ", " ", "0", " ", " ", "|" },
                                   { " ", " ", " ", " ", " ", " ", " ", "‾", "‾", "‾", "‾", "‾", "‾", " " } };

        //These are the coordinates of the player spawn 
        static int xPlayer = 20; 
        static int yPlayer = 17;

        //This function spawnes the player in the coordinates that mentioned above
        static void PlayerSpawn()
        {

            Console.SetCursorPosition(xPlayer, yPlayer);

            for (int i = 0; i < player.GetLength(0); i++)
            {
                for (int j = 0; j < player.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j + xPlayer, i + yPlayer);
                    Console.Write(player[i,j]);
                }
                Console.WriteLine(" ");
            }
        }

        

        //This is a emptry line that erase the leftovers from the player
        static string[] emptyLine = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        //This function erae the leftovers from the player when he moves
        static void LeftoversEraser(int TheYCordinateOfThePlayer)
        {
            Console.SetCursorPosition(xPlayer, TheYCordinateOfThePlayer);
           
            for (int i = 0; i < emptyLine.Length; i++)
            {
                Console.Write(emptyLine[i]);
            }
        }

        //This function is moving the player up,down,right and left 
        static void PlayerMovment()
        {
            PlayerSpawn();

            int Endless = 0; //this variable will be changed to "when you loss the game"

            ConsoleKeyInfo playerKeyInfo;
            
            do
            {
                playerKeyInfo = Console.ReadKey(true);

                switch (playerKeyInfo.Key)
                {
                    case ConsoleKey.W:
                        yPlayer--;
                        PlayerSpawn();
                        LeftoversEraser(yPlayer + 5);
                        break;
                    case ConsoleKey.S:
                        yPlayer++;
                        PlayerSpawn();
                        LeftoversEraser(yPlayer - 1);
                        break;
                    case ConsoleKey.A:
                        xPlayer--;
                        PlayerSpawn();
                        break;
                    case ConsoleKey.D:
                        xPlayer++;
                        PlayerSpawn();
                        break;
                } 

                
            } while (Endless == 0);
            

        }

        //This fucntion contains all the other functions and running the game
        static void ThWholeGame()
        {
            windowsize();
            borders();
            PipesSpawn();
            PlayerMovment();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            ThWholeGame();
        }
    }
}
