using System;

namespace flafy_game
{
    class Program
    {
        
        static void windowsize()
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 150;
        }

        static void barrier()
        {
            string[] bothbarriers = new string[150];

            //bottom barrier
            for (int i = 0; i < bothbarriers.Length; i++)
            {
                Console.SetCursorPosition(i, 29);
                Console.Write("#");
            }
            //upper barrier
            for (int j = 0; j < bothbarriers.Length; j++)
            {
                Console.SetCursorPosition(j, 0);
                Console.Write("#");
            }
        }

        static void pipe()
        {
            int randomnumber;

            Random randompipeplace = new Random();
            randomnumber = randompipeplace.Next(20, 150);

            for (int i = 0; i < 28; i++)
            {
                Console.SetCursorPosition(randomnumber, i + 1);
                Console.Write("|");
            }


        }
        



        static string[,] player ={ { " ", " ", " ", " ", " ", " ", " ", "_", "_", "_", "_", "_", "_", " " },
                                   { " ", "_", "_", " ", " ", " ", "|", " ", "o", " ", " ", " ", "o", "|" },
                                   { " ", " ", " ", "|", "-", "-", "|", " ", " ", " ", "^", " ", " ", "|" },
                                   { " ", "‾", "‾", " ", " ", " ", "|", " ", " ", " ", "0", " ", " ", "|" },
                                   { " ", " ", " ", " ", " ", " ", " ", "‾", "‾", "‾", "‾", "‾", "‾", " " } };

        static void PlayerSpawn(int x, int y)
        {
            Console.SetCursorPosition(x, y);

            for (int i = 0; i < player.GetLength(0); i++)
            {
                for (int j = 0; j < player.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j + x,i + y);
                    Console.Write(player[i,j]);
                }
                Console.WriteLine(" ");
            } 
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PlayerSpawn(8, 11);
           
            windowsize();
            barrier();
            pipe();
            

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
    }
}
