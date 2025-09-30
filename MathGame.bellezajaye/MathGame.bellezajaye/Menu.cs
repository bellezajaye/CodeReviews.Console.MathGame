namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game.");
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.WriteLine("What game would you like to play today? Choose from the options below:");
                Console.WriteLine(@"
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program ");
                Console.WriteLine("-------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game.");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game.");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game.");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game.");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye!");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);
        }
    }
}
