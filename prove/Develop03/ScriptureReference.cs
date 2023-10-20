using System;
using System.Text.RegularExpressions;

public class ScriptureReference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int VerseStart { get; private set; }
    public int VerseEnd { get; private set; }

    public ScriptureReference(string reference)
    {
        string pattern = @"^(?<book>[\w\s]+) (?<chapter>\d+):(?<verseStart>\d+)(?:-(?<verseEnd>\d+))?$";
        Match match = Regex.Match(reference, pattern);

        if(match.Success)
        {
            Book = match.Groups["book"].Value;
            Chapter = int.Parse(match.Groups["chapter"].Value);
            VerseStart = int.Parse(match.Groups["verseStart"].Value);

            if(match.Groups["verseEnd"].Success)
            {
                VerseEnd = int.Parse(match.Groups["verseEnd"].Value);
            }
        }
        else
        {
            throw new ArgumentException("Invalid format!");
        }
    }

    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
    }

    public ScriptureReference(string book, int chapter, int verse, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = verseEnd;
    }

    private void ParseReference(string reference)
    {
        // Split and parse the scripture reference
        string[] parts = reference.Split(' ');

        if (parts.Length < 2)
        {
            throw new ArgumentException("Invalid scripture reference format.");
        }

        Book = parts[0];
        string[] chapterVerse = parts[1].Split(':');

        if (chapterVerse.Length < 2)
        {
            throw new ArgumentException("Invalid scripture reference format.");
        }

        Chapter = int.Parse(chapterVerse[0]);

        string[] verseParts = chapterVerse[1].Split('-');
        VerseStart = int.Parse(verseParts[0]);

        if (verseParts.Length > 1)
        {
            VerseEnd = int.Parse(verseParts[1]);
        }
        else
        {
            VerseEnd = VerseStart;
        }
    }
   

    public override string ToString()
    {
        if (VerseStart == VerseEnd)
        {
            return $"{Book} {Chapter}:{VerseStart}";
        }
        else
        {
            return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
        }
    }
}

//NOTES
