namespace HighLowNumberGuessing;

class Program
{
    static void Main(string[] args)
    {
        const int MIN_NUMBER = 1;
        const int MAX_NUMBER = 100;
        const int MAX_GUESSES = 10;
        const int CLOSED_DISANCE = 5;

        Console.WriteLine("Welcome to the High Low Number Guesser!");

        Random random = new Random();
        int randomNumber = random.Next(MIN_NUMBER, MAX_NUMBER + 1);

        
        for (int guessCount = 0; guessCount < MAX_GUESSES; guessCount++)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int difference = Math.Abs(number - randomNumber);
            Console.WriteLine($"Guess {guessCount + 1} of {MAX_GUESSES}");
            
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

            if (difference == CLOSED_DISANCE )
            {
                Console.WriteLine($"You are close!.");
            }
            
        }
        Console.WriteLine($"You lose! The number was {randomNumber}.");
    }
}