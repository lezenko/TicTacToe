using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace TicTacToe
{

    public static class Player
    {
        public static int turns { get; set; }
        public static string playerTurn = "X";
        public static bool winner = false;
        public static bool boardTaken = true;
        public static string[,] board =
{
    {"1","2","3"},
    {"4","5","6"},
    {"7","8","9"}
};
        public static int Input(int input)
        {
            bool withinRange = false;
            do
            {
                if (input >= 1 && input <= 9)
                {
                    withinRange = true;
                    PushBoard(input);
                    Console.WriteLine("You entered {0}", input); 
                }
                else
                {
                    Console.WriteLine("Number not on the board.");
                    Valid();
                    break;
                }

            }
            while (withinRange == false);

            return input;
        }

        public static void Valid()
        {
            bool isNumber = false;
            do
            {

                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("You didn't enter a number");
                    isNumber = false;

                }
                else
                {
                    Input(number);
                    isNumber = true;
                }
            } while (isNumber == false);

        }
        public static void PushBoard(int pushNum)
        {
            if (pushNum % 1 == 0)
            {

                string test = pushNum.ToString();
                NumCheck(boardTaken, test);
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {

                        if (boardTaken == false)
                        {
                            Board.Display();


                        }
                        else if (board[i, j] == test && winner == false)
                        {
                            board[i, j] = playerTurn;
                            NextPlayerTurn();
                            Board.Display();
                            Console.WriteLine("It's now Player {0}'s turn", playerTurn);
                            turns++;
                        }
                    }
                }
            }
        }
        public static void NextPlayerTurn()
        {
            if (playerTurn == "X")
            {
                playerTurn = "O";
            } else
            {
                playerTurn = "X";
            }
        }
        public static void WinConditions()
        {
            // across
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2]) { winner = true; }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2]) { winner = true; }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2]) { winner = true; }
            // down
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0]) { winner = true; }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1]) { winner = true; }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2]) { winner = true; }
            //diag
            else if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2]) { winner = true; }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) { winner = true; }

        }
        public static bool NumCheck(bool valid, string input)
        {
            if (board[0, 0] == input)
            {
                return false;
            }
            else if (board[0, 1] == input)
            {
                return false;
            }
            else if (board[0, 2] == input)
            {
                return false;
            }
            else if (board[1, 0] == input)
            {
                return false;
            }
            else if (board[1, 1] == input)
            {
                return false;
            }
            else if (board[1, 2] == input)
            {
                return false;
            }
            else if (board[2, 0] == input)
            {
                return false;
            }
            else if (board[2, 1] == input)
            {
                return false;
            }
            else if (board[2, 2] == input)
            {
                return false;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number has been taken");
                Console.ResetColor();
                return true;
            }
        }

        public static void Test()
        {
            Console.WriteLine(board[1, 2] + board[0, 1] + board[0, 2]);
        }
        public static void Reset()
        {
            turns = 0;
            playerTurn = "X";
            winner = false;
            boardTaken = true;
    
        }
        
    }
}
