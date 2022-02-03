using TicTacToe;
string cont = "y";
do {
    Board.Display();
    Console.WriteLine("Enter the number on the board you wish to take");
    Player.Valid();
        while (Player.winner == false && Player.turns < 9)
        {
            Player.Valid();
            Player.WinConditions();

        }
    Player.NextPlayerTurn();
    if (Player.winner == true) { 
    Console.WriteLine("WINNER! - {0}", Player.playerTurn);
    } else
    {
        Console.WriteLine("DRAW!");
    }
    Console.WriteLine("Do want to play again? Hit Y/N");
    cont = Console.ReadLine();
    Board.Reset();
} 
while (cont == "y") ;

