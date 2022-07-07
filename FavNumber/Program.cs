

Console.WriteLine("Guess a random number from 1 - 1000");
var r = new Random();
var randomNumber = r.Next(1, 1000);
var userInput = int.Parse(Console.ReadLine());


if (userInput > randomNumber)
{
    Console.WriteLine("too low");
}

else if (userInput < randomNumber)
{
    Console.WriteLine("too high");
}

else
{
    Console.WriteLine("You guessed it!!!!");
}