using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        User user = new User();

        // Sample goals
        Goal marathonGoal = new SimpleGoal("Run a Marathon", 1000);
        Goal readScripturesGoal = new EternalGoal("Read Scriptures", 100);
        Goal attendTempleGoal = new ChecklistGoal("Attend Temple", 50, 10);

        user.AddGoal(marathonGoal);
        user.AddGoal(readScripturesGoal);
        user.AddGoal(attendTempleGoal);

        // Record events
        user.RecordEvent(marathonGoal);
        user.RecordEvent(readScripturesGoal);
        user.RecordEvent(attendTempleGoal);
        user.RecordEvent(attendTempleGoal); // Record multiple times for checklist goal

        // Display goals and score
        user.DisplayGoals();
    }
}