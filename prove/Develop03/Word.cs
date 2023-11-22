public class Word 
{
    private string _text;
    private bool _isHidden;

    public Word (string words)
    {

    }
    public void Hide()
    {
        _text = "_____";
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return " ";
    }
}