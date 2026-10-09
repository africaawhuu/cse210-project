using System;

// ==============================================================================================
// CREATIVITY & EXCEEDING REQUIREMENTS:
// 1. Dynamic Leveling System: Tracks user score thresholds (every 1000 points) and assigns title 
//    ranks (Novice Traveler -> Eternal Champion) alongside dynamic level-up notifications.
// 2. Negative Goals (NegativeGoal.cs): Added habit-breaking tracker goals that deduct point 
//    penalties when recorded to incentivize positive habits.
// ==============================================================================================

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}