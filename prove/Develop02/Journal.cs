public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            Console.WriteLine(i);
        }
    }

    public void SaveToFIle(string file)
    {
        
    }
}