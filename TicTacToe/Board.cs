using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine($"| {Player.board[0, 0]} | {Player.board[0, 1]} | {Player.board[0, 2]} |\n" +
    $" -----------\n" +
    $"| {Player.board[1, 0]} | {Player.board[1, 1]} | {Player.board[1, 2]} |\n" +
    $" -----------\n" +
    $"| {Player.board[2, 0]} | {Player.board[2, 1]} | {Player.board[2, 2]} |\n");
        }
        public static void Reset()
        {
            Player.Reset();
            Player.board[0, 0] = "1";
            Player.board[0, 1] = "2";
            Player.board[0, 2] = "3";
            Player.board[1, 0] = "4";
            Player.board[1, 1] = "5";
            Player.board[1, 2] = "6";
            Player.board[2, 0] = "7";
            Player.board[2, 1] = "8";
            Player.board[2, 2] = "9";
        }
    }
}
