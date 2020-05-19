using System;

namespace Madlib
{
    class Program
    {
        static void Main()
        {
            Madlib.Run();
        }
    }

    static class Madlib
    {
        //declare variables
        static string Creature;
        static string Luminous;
        static string Ghastly;
        static string Spectral;
        static string Countryman;
        static string Farrier;
        static string Farmer;
        static string Dreadful;
        static string Apparition;
        static string Hound;
        static string Story;

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            EndGame();
        }

        static void Start()
        {
            //write out a header
            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("--------");
        }

        static void GetWords()
        {
            //ask player to enter words
            Console.WriteLine("Please enter a noun: ");
            Creature = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Luminous = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Ghastly = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Spectral = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Countryman = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Farrier = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Farmer = Console.ReadLine();

            Console.WriteLine("Please enter an adjective: ");
            Dreadful = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Apparition = Console.ReadLine();

            Console.WriteLine("Please enter a noun: ");
            Hound = Console.ReadLine();
        }

        static void WriteStory()
        {
            //write out finished story
            Story = $"They all agreed that it was a huge {Creature}, {Luminous}, {Ghastly}, and {Spectral}. " +
                    $"I have cross - examined these men, one of them a hard-headed {Countryman}, one a {Farrier}, " +
                    $"and one a moorland {Farmer}, who all tell the same story of this {Dreadful} {Apparition}, " +
                    $"exactly corresponding to the {Hound} of the legend.";
            Console.WriteLine(Story);
        }

        static void EndGame()
        {
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }

    }

    //How to write unit tests for text application?
    //tupee, slim, itchy, expensive, head, chrome dome, ford head, oily, scalp, crown
}
