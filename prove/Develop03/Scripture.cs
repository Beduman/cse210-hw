using System;
public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;
    private char _remover = ' ';

    public object Parse { get; }

    public Scripture(string scripture)
    {
        string[] scriptureList = scripture.Split(_remover);
        foreach (string i in scriptureList)
        {
            _words.Add(i);
        }
        HideRandomWords(scriptureList);
    }

    public void HideRandomWords(string [] scriptureList)
    {
        int totalCount = scriptureList.Count();
        Random random = new Random();
        int wordsToHideCount = random.Next(1, totalCount);
    }
    public string GetDisplayText()
    {
        foreach(Word i in _words)
        {
            bool hidden = i.IsHidden();
            if (hidden = true)
            {
                Console.Write("______");
            }
            else if (hidden = false)
            {
                Console.Write(i);
            }
        }
        return "";
    }
    public bool IsCompletelyHidden()
    {
        bool TotalHidden = true;
        return TotalHidden;
    }
}