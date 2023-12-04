using System.IO; 

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;


    public Goal(string name, string description, string points)
    {

    }
    public Goal(){}

    virtual public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        bool example = false;

        return example;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public string GetStringRepresentation()
    {
        return "";
    }
        public int GetPoints()
    {
        return _points;
    }
}