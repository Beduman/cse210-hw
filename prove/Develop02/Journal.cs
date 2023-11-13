public class Journal
{
    public List<string> _journalEntries;


    public void DisplayAll()
    {
        foreach (string i in _journalEntries)
        {
            Console.WriteLine(i);
        }
    }

    public void SaveToFIle(string newEntry)
    {
        _journalEntries.Add(newEntry);
    }
}