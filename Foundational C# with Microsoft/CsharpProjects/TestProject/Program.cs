Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = SetTarget();
        var roll = SetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? userInput = Console.ReadLine();
    if (userInput != null && userInput.ToUpper() == "Y")
    {
        return true;
    }

    return false;
}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You win!" : "You lose!";
}

int SetTarget()
{
    return random.Next(1, 6); // 1-5
}

int SetRoll()
{
    return random.Next(1, 7); // 1-6
}
