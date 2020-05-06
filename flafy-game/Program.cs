using System;

namespace flafy_game
{
    class Program
    {
        //ivan    This function sets the size of the game
        static void windowsize()
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 180;
        }

        //ivan    This function sets the borders of the game
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

        //ivan    This is how the pipe looks like
        static string[,] pipe = { {"|"},
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

        //ivan    This fucntion spawn one pipe with a random hole in her
        static void pipespawn()
        {
            
            int randomnumber;

            Random randomholeselector = new Random();
            randomnumber = randomholeselector.Next(4,34);
            
            
               for (int i = 0; i < pipe.GetLength(1); i++)
                {
                    for (int j = 0; j < pipe.GetLength(0); j++)
                    {
                        
                       if (!(j <= randomnumber + 3 && j >= randomnumber - 3))
                       {
                        Console.SetCursorPosition(179, j + 1);
                        Console.Write(pipe[j, i]);
                        

                       }
                    }
                }
            

        }
        


        
        //liron   This is how the player looks like
        static string[,] player ={ { " ", " ", " ", " ", " ", " ", " ", "_", "_", "_", "_", "_", "_", " " },
                                   { " ", "_", "_", " ", " ", " ", "|", " ", "o", " ", " ", " ", "o", "|" },
                                   { " ", " ", " ", "|", "-", "-", "|", " ", " ", " ", "^", " ", " ", "|" },
                                   { " ", "‾", "‾", " ", " ", " ", "|", " ", " ", " ", "0", " ", " ", "|" },
                                   { " ", " ", " ", " ", " ", " ", " ", "‾", "‾", "‾", "‾", "‾", "‾", " " } };

        //liron   These are the coordinates of the player spawn 
        static int xPlayer = 20; 
        static int yPlayer = 17;

        //liron   This function spawnes the player in the coordinates that mentioned above
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

        //liron   This function is moving the player up,down,right and left 
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
                        break;
                    case ConsoleKey.S:
                        yPlayer++;
                        PlayerSpawn();
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

        //liron   This fucntion contains all the other functions and running the game
        static void ThWholeGame()
        {
            windowsize();
            borders();
            pipespawn();
            PlayerMovment();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ThWholeGame();
        }
    }
}
