using System;
using System.Globalization;
using System.Collections.Generic;

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
        const int NUMOFWORDS = 10;
        static List<string> Words = new List<string> { };

        static string[] Prompts =
        {
            "noun",
            "adjective",
            "adjective",
            "adjective",
            "noun",
            "noun",
            "noun",
            "adjective",
            "adjective",
            "noun"
        };

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            EndGame();
        }

        static void Start()
        {
            //Set window bar title
            Console.Title = "Make a Madlib";

            //write out a header
            Console.WriteLine("--------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("--------");
        }

        static void GetWords()
        {
            //ask player to enter words
            for (int i = 0; i < NUMOFWORDS; i++)
            {
                Console.WriteLine($"Please enter a/an {Prompts[i]}: ");
                Words.Add(Console.ReadLine());
            }           
        }

        static void WriteStory()
        {
            //write out finished story
            string Story = $"They all agreed that it was a huge {Words[0]}, {Words[1]}, {Words[2]}, and {Words[3]}. " +
                           $"I have cross - examined these men, one of them a hard-headed {Words[4]}, one a {Words[5]}, " +
                           $"and one a moorland {Words[6]}, who all tell the same story of this {Words[7]} {Words[8]}, " +
                           $"exactly corresponding to the {Words[9]} of the legend.";
            Console.WriteLine(Story);
        }

        static void EndGame()
        {
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
