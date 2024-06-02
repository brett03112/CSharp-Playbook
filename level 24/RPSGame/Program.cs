
/*
    This is a game of Rock, Paper, Scissors played by two players.
    @author: Brett Smith


*/
RPSGame game = new RPSGame();

game.Play();


public class RPSGame
{
    public string? Player1 { get; set; } = "Player_1";
    public string? Player2 { get; set; } = "Player_2";

    public void Play() 
    {
        bool playAgain = true;
        while (playAgain)
        {
            string? player1Choice = GetPlayerChoice(Player1)!;
            string? player2Choice = GetPlayerChoice(Player2)!;
            string? winner = GetWinner(player1Choice, player2Choice);
            WriteLine($"The winner is {winner}");
            playAgain = GetPlayAgain();
        }
    }

    public string? GetPlayerChoice(string? player)
    {
        WriteLine($"{player}Choose Rock, Paper, or Scissors");
        
        string? playerChoice = ReadLine()!.ToUpper();

        return playerChoice!;
        
    }

    public string? GetWinner(string? player1Choice, string? player2Choice)
    {
        if (player1Choice == player2Choice)
        {
            return "It's a Tie!";
        }
        else if (player1Choice == "ROCK" && player2Choice == "SCISSORS")
        {
            return player1Choice;
        }
        else if (player1Choice == "PAPER" && player2Choice == "ROCK")
        {
            return player1Choice;
        }
        else if (player1Choice == "SCISSORS" && player2Choice == "PAPER")
        {
            return player1Choice;
        }
        else
        {
            return player2Choice;
        }

    }

    public bool GetPlayAgain()
    {
        WriteLine("Would you like to play again? (Y/N)");
        string? playAgain = ReadLine()!.ToUpper();
        if (playAgain == "Y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

