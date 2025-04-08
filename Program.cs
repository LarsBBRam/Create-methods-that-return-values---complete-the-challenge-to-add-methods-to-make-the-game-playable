using System.Security.Cryptography.X509Certificates;

namespace Create_methods_that_return_values___complete_the_challenge_to_add_methods_to_make_the_game_playable;

class Program
{
    static void Main(string[] args)
    {
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
                var target = GetTarget();
                var roll = RollDice();

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        bool ShouldPlay()
        {
            string response = Console.ReadLine();

            return response.ToLower().Equals("y");
        }

        int GetTarget()
        {
            return random.Next(1, 6);
        }

        int RollDice()
        {
            return random.Next(1, 7);
        }
        string WinOrLose(int roll, int target)
        {
            if (roll > target)
            {
                return "You win!";
            }
            return "You lose!";
        }
    }
}
