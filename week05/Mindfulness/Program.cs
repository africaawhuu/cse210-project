// EXCEEDING REQUIREMENTS:
// 1. Session Activity Tracker: Added static variables in Program.cs to track total sessions completed and overall duration spent in mindfulness during the run.
// 2. Question Deduplication: Implemented a reset-buffer mechanism in ReflectionActivity.cs ensuring no reflection questions repeat until all available questions have been shown once.

using System;

class Program
{
    private static int _totalSessions = 0;
    private static int _totalSecondsMindful = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View session stats (Extra Feature)");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    RecordSession(breathing.GetDuration());
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    RecordSession(reflection.GetDuration());
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    RecordSession(listing.GetDuration());
                    break;

                case "4":
                    DisplayStats();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private static void RecordSession(int duration)
    {
        _totalSessions++;
        _totalSecondsMindful += duration;
    }

    private static void DisplayStats()
    {
        Console.Clear();
        Console.WriteLine("=== Mindfulness Session Statistics ===");
        Console.WriteLine($"Total activities completed: {_totalSessions}");
        Console.WriteLine($"Total mindfulness time:     {_totalSecondsMindful} seconds");
        Console.WriteLine("=======================================");
        Console.WriteLine("\nPress Enter to return to the main menu.");
        Console.ReadLine();
    }
}