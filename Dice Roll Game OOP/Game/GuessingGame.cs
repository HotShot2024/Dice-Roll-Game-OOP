

using Dice_Roll_Game_OOP.UserCommunication;

namespace Dice_Roll_Game_OOP.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number: ");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;

                }
                Console.WriteLine("Wrong number.");
                --triesLeft;
            }
            return GameResult.Loss;

        }// Play closed

        public static void Printresult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                   ? "You win!"
                   : "You lose :( ";

        }
    } // Guessinggame closed
}
