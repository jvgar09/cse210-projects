using System;

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }
    public string HiddenText { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
        HiddenText = "";
        foreach( char letter in text )
        {
            HiddenText += "_";
        }
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }
}
