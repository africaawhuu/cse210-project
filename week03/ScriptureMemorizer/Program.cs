/*
 * Exceeding Requirements / Creativity Report:
 * 1. Smart Word Selection: Modified `Scripture.HideRandomWords` to strictly pick from words that are NOT already hidden, preventing redundant selections and ensuring steady progress.
 * 2. Scripture Library: Included a library of multiple scriptures in `Program.cs` that selects a passage at random each time the program runs.
 */

using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scripture Library
            List<Scripture> library = new List<Scripture>
            {
                new Scripture(
                    new Reference("Proverbs", 3, 5, 6),
                    "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
                ),
                new Scripture(
                    new Reference("John", 3, 16),
                    "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
                ),
                new Scripture(
                    new Reference("Ether", 12, 27),
                    "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me."
                )
            };

            // Select a random scripture from the library
            Random random = new Random();
            Scripture currentScripture = library[random.Next(library.Count)];

            // Interactive loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine();

                if (currentScripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.Write("Press enter to continue or type 'quit' to finish: ");
                string input = Console.ReadLine();

                if (input != null && input.Trim().ToLower() == "quit")
                {
                    break;
                }

                currentScripture.HideRandomWords(3);
            }
        }
    }
}