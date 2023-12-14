using System;

public class Enemy : Character
{
    //total stats

    public Enemy(int enemyClass)
    {

    }
    public Enemy()
    {
        
    }
    protected virtual void SetNewClass(int newClass)
    {

    }
    protected virtual void Set1()
    {
        SetStats(80, 35, 1, 100, 50, 2);
        _name = "bad guy";
    }
    protected virtual void Set2()
    {
        SetStats(100, 8, 3, 80, 60, 4);
        _name = "nerd";
    }
    protected virtual void Set3()
    {
        SetStats(1140, 8, 1, 60, 100, 6);
        _name = "Meanie";
    }

}
