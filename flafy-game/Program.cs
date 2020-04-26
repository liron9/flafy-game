using System;

namespace flafy_game
{
    class Program
    {
        static void PlayerView(int x, int y)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[,] player = { { " ", " ", " ", " ", " ", " ", " ", "_", "_", "_", "_", "_", "_", " " },
                                 { " ", "_", "_", " ", " ", " ", "|", " ", "o", " ", " ", " ", "o", "|" },
                                 { " ", " ", " ", "|", "-", "-", "|", " ", " ", " ", "^", " ", " ", "|" },
                                 { " ", "‾", "‾", " ", " ", " ", "|", " ", " ", " ", "0", " ", " ", "|" },
                                 { " ", " ", " ", " ", " ", " ", " ", "‾", "‾", "‾", "‾", "‾", "‾", " " } };
           
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
            PlayerView(8, 11);
            Console.ReadKey();

        }
    }
}
