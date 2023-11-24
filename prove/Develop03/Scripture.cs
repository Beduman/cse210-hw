public class Scripture 
{
    private List<Word> _words = new List<Word>();
    private char _remover = ' ';
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
        
        int totalCount = scriptureList.Count();
        Random random = new Random();

        int wordsToHideCount = random.Next(1, totalCount);
        foreach (Word i in _words)
        {
            int spot = _words.IndexOf(i);
            if (wordsToHideCount == spot)
            {   
                i.Hide();
            }
        }

    }
    public List<string> GetDisplayText()
    {
        List<string> returnText = new List<string>();
        foreach(Word i in _words)
        {
            bool hidden = i.IsHidden();
            if (hidden == true)
            {
                string blank = "______";
                returnText.Add(blank);

            }
            else if (hidden == false)
            {
                string shown = i.GetDisplayText();
                returnText.Add(shown);
            }

        }
        return returnText;
    }
    public bool IsCompletelyHidden()
    {
        bool TotalHidden = true;
        return TotalHidden;
    }
}