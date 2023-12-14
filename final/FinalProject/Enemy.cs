using System;

public class Enemy : Character
{
    //total stats

    public Enemy(int enemyClass)
    {
        SetNewClass(enemyClass);
    }
    public Enemy()
    {
        
    }
    protected virtual void SetNewClass(int newClass)
    {
        if (newClass == 1)
        {
            Set1();
        }
        if (newClass == 2)
        {
            Set2();
        }
        if (newClass == 3)
        {
            Set3();
        }
    }
    protected virtual void Set1()
    {
        SetStats(80, 35, 1, 95, 5, 2);
        _name = "bad guy";
    }
    protected virtual void Set2()
    {
        SetStats(100, 15, 3, 75, 10, 4);
        _name = "nerd";
    }
    protected virtual void Set3()
    {
        SetStats(1140, 15, 1, 55, 15, 6);
        _name = "Meanie";
    }

}
