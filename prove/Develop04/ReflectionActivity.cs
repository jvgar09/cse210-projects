class ReflectionActivity : MindfullActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you smiled at someone that made you mad."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "How did this make you feel."
    };

    public ReflectionActivity(int duration) : base(duration)
    {
        name = "Reflecting Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
    }

    public void Execute()
    {
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        // PUT "When you have something in mind press enter to continue"
        // GET input
        foreach (string question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Spinner(5);
        }
    }
}