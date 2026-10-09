using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int pointsToDeduct) 
        : base(name, description, pointsToDeduct)
    {
    }

    public override void RecordEvent(ref int userScore)
    {
        userScore -= GetPoints();
        if (userScore < 0) userScore = 0;
        Console.WriteLine($"\nPenalty Recorded! You lost {GetPoints()} points for engaging in a bad habit.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[-] {GetName()} ({GetDescription()}) [Penalty: -{GetPoints()} pts]";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}