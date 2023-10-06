using System;

public class PromptGenerator
{
    private Random _random = new Random();
    private string [] _prompts; 
    public PromptGenerator()
    { 
        _prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",     
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Who was I nice to today, what did I do for them?",
            "What did I learn form my scripture reading?",
            "What brings you joy?",
            "What is something that you would like to change about yourself? How can you change it?",
            "What happened to me today?",
            "What was the most challenging thing I faced today?",
            "What did I learn today?",
            "What was the most fun thing I did today?",
            "What was the most surprising thing that happened today?",
        }; 
    }
    public string Display()
    {
        int index = _random.Next(0, _prompts.Length);
        return _prompts[index];
    }

}