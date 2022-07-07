

Console.WriteLine("Guess a random number from 1 - 10");
var r = new Random();
var randomNumber = r.Next(1, 10);
int userInput; 


while (true) {

    userInput = int.Parse(Console.ReadLine());

    if (userInput < randomNumber)
    {
        Console.WriteLine("Too low... try again.");
    }

    else if (userInput > randomNumber)
    {
        Console.WriteLine("Too high... try again.");
    }

    else
    {
        Console.WriteLine($"Correct! {randomNumber} is the correct guess!");
        break;
    }

}