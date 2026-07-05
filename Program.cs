namespace HighLowNumberGuessing;

class Program
{
    static void Main(string[] args)
    {
        const int MinNumber = 1;
        const int MaxNumber = 100;
        const int MaxGuesses = 10;
        const int ClosedDistance = 5;

        Console.WriteLine("Welcome to the High Low Number Guesser!");

        Random random = new Random();
        int randomNumber = random.Next(MinNumber, MaxNumber + 1);

        
        for (int guessCount = 0; guessCount < MaxGuesses; guessCount++)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int difference = Math.Abs(number - randomNumber);
            Console.WriteLine($"Guess {guessCount + 1} of {MaxGuesses}");
            
            if (number < randomNumber)
            {
                Console.WriteLine("too low");
            } else if (number > randomNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine($"You won");
                return;
            }

            if (difference == ClosedDistance)
            {
                Console.WriteLine($"You are close!.");
            }
            
        }
        Console.WriteLine($"You lose! The number was {randomNumber}.");
    }
}