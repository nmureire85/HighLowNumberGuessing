namespace HighLowNumberGuessing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the High Low Number Guesser!");


        for (int guessCount = 0; guessCount < 10; guessCount++)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int difference = Math.Abs(number - randomNumber);

            if (number < randomNumber)
            {
                Console.WriteLine("too low");
            }

            if (number > randomNumber)
            {
                Console.WriteLine("too high");
            }

            if (number == randomNumber)
            {
                Console.WriteLine("You won");
                return;
            }

            if (difference <= 5)
            {
                Console.WriteLine($"You are close!. The random  number was {randomNumber}");
            }

            Console.WriteLine($"number of guesses : {guessCount} ");
            if (guessCount < 5)
            {
                continue;
            }

            Console.WriteLine("You lose");
            break;
        }
    }
}