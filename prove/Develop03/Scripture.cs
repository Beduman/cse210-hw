using System;
using System.Globalization;
public class Scripture 
{
    private Reference _reference;
    private List<Word> _words;
    private char _remover = ' ';
    List<string> returnText;
    public object Parse { get; }

    public Scripture(string scripture)
    {
        string[] scriptureList = scripture.Split(_remover);
        foreach (string word in scriptureList)
            {
                Word wordObject = new(word);
                _words.Add(wordObject);
            }
    
    }

    public void HideRandomWords(List<string>scriptureList)
    {
        //Also having trouble placing the random word back into the list
        int totalCount = scriptureList.Count();
        Random random = new Random();
        int wordsToHideCount = random.Next(1, totalCount);

        foreach (Word i in _words)
        {
            
        }

    }
    public List<string> GetDisplayText()
    {
        
        foreach(Word i in _words)
        {
            bool hidden = i.IsHidden();
            if (hidden = true)
            {
                string blank = "______";
                returnText.Add(blank);

            }
            else if (hidden = false)
            {
                string shown = i;
                returnText.Add(shown);
            }

            Console.WriteLine(returnText);
        }
        return returnText;
    }
    public bool IsCompletelyHidden()
    {
        bool TotalHidden = true;
        return TotalHidden;
    }
}