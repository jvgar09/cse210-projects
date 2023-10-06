using System;
public class Journal {
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._answer}");
            }
        }
    }

    public void LoadFile()
    {
        if (File.Exists(_fileName))
        {
            string[] lines = System.IO.File.ReadAllLines( _fileName);
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._answer = parts[2];
                _entries.Add(entry);

            }

        }
        else
        {
            Console.WriteLine("Such File name dose not exists! ");
        }
    }

}