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
                var target;
                var roll;

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose());
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        bool ShouldPlay()
        {
            return true;
        }

        bool WinOrLose()
        {
            return true;
        }
    }
}
