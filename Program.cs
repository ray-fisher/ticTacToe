using System;

namespace ticTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            Initialize(board);
            int moves = 0;
            bool game = true;
            while (game == true)
            {
                Console.Clear();
                Print(board);

                Console.Write("Please enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                bool spotTaken = false;
                while (spotTaken == false)
                {
                    if (board[row, col] == ' ')
                    {
                        board[row, col] = player;
                        spotTaken = true;
                    }
                    else if(board[row, col] != ' ')
                    {
                        Console.Write("Spots Taken: \n");
                        Console.Write("Please enter row: ");
                        row = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter column: ");
                        col = Convert.ToInt32(Console.ReadLine());
                    }
                }

                board[row, col] = player;
                game = Win(board, player);

                moves = moves + 1;
                if (moves == 9)
                {
                    Console.WriteLine("Draw");
                    break;
                }

                player = ChangeTurn(player);

            }

        }

        static bool Win(char[,] board, char player)
        {
            bool game = true;

            if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;
            }
            if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;

            }
            if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;

            }
            if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;

            }
            if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;

            }
            if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;

            }
            if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;

            }
            if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
            {
                Console.WriteLine(player + " has won the game!");
                game = false;
            }
            return game;
        }

        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }
        static void Print(char[,] board)
        {
            // Printing Board
            Console.WriteLine(" | 0 | 1 | 2 |");

            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

    }
}
