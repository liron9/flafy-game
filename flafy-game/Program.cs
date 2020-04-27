using System;

namespace flafy_game
{
    class Program
    {
      // static Console.OutputEncoding = System.Text.Encoding.UTF8;

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
            PlayerSpawn(8, 11);

           while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
    }
}
