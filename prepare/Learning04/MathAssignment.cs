public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section}, Problems {_problems}";
    }
}