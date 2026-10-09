using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent(ref int userScore)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            userScore += GetPoints();
            Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("\nThis goal has already been completed!");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}