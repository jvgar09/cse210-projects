using System;

// Class to represent the scripture itself
public class Scripture
{
    private List<Word> words;
    public ScriptureReference Reference { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = new ScriptureReference(reference);
        // Split the text into words and create Word objects for each word
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Memorize this Scripture: {Reference.Book} {Reference.Chapter}:{Reference.VerseStart}-{Reference.VerseEnd}\n");

        foreach (var word in words)
        {
            Console.Write(word.IsHidden ? "____ " : $"{word.Text} ");
        }

        Console.WriteLine("\n");
    }

    public bool HideRandomWord()
    {
        // Find a random word that is not already hidden
        var random = new Random();
        var visibleWords = words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count == 0)
        {
            // All words are hidden
            return false;
        }

        var randomIndex = random.Next(0, visibleWords.Count);
        visibleWords[randomIndex].Hide();

        return true;
    }
}
