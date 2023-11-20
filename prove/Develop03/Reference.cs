public class Reference
{
    private string _book;   // All of my attributes are private – they can only be used in this class
    private int _chapter;
    private int _verse;

    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        // First constructor – Need to set all the attributes to an initial value using the parameters in this function
        // You are not given the endVerse, so you have to initialize it something
        string _displayText = GetDisplayText();
    }
    public string GetDisplayText()
    {
        string _displayText = $"{_book} {_chapter}:{_verse}";
        // Create a string that has the book, chapter, verse, and endVerse (if its used)
        // In stub code, if the function is supposed to return something, then we make something up for now
        return _displayText;
    }
}