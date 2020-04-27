using System;

namespace flafy_game
{
    class Program
    {
        //ivan
        static void windowsize()
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 180;
        }

        //ivan
        static void barrier()
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

        //ivan
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
        //ivan
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
        


        
        //liron
        static string[,] player ={ { " ", " ", " ", " ", " ", " ", " ", "_", "_", "_", "_", "_", "_", " " },
                                   { " ", "_", "_", " ", " ", " ", "|", " ", "o", " ", " ", " ", "o", "|" },
                                   { " ", " ", " ", "|", "-", "-", "|", " ", " ", " ", "^", " ", " ", "|" },
                                   { " ", "‾", "‾", " ", " ", " ", "|", " ", " ", " ", "0", " ", " ", "|" },
                                   { " ", " ", " ", " ", " ", " ", " ", "‾", "‾", "‾", "‾", "‾", "‾", " " } };
        //liron
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

            PlayerSpawn(20, 17);
           
            windowsize();
            barrier();
            pipespawn();
            

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
    }
}
