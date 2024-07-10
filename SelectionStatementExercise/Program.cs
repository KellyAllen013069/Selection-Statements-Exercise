namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 88;
            
            Console.WriteLine("Guess the number between 1 and 100");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber) Console.WriteLine("Too low.");
            else if (userInput > favNumber) Console.WriteLine("Too high");
            else Console.WriteLine($"Congratulations! You guessed the correct number {favNumber}.");
        }
    }
}
