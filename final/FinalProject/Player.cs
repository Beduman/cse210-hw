using System;

public class Player : Character
{


    public string _className;
    public Player()
    {
        
    }
    public Player(int newClass) : base()
    {
        SetNewClass(newClass);
    }
    public void SetNewClass(int newClass)
    {
        if (newClass == 1)
        {
            SetRogue();
        }
        if (newClass == 2)
        {
            SetBreaker();
        }
        if (newClass == 3)
        {
            SetTank();
        }
        if (newClass == 4)
        {
            SetCaster();
        }
    }
    public void SetRogue()
    {
        SetStats(90, 40, 1, 100, 5, 2);
        _className = "rogue";
    }
    public void SetBreaker()
    {
        SetStats(110, 30, 3, 80, 10, 4);
        _className = "breaker";
    }
    public void SetTank()
    {
        SetStats(150, 20, 1, 60, 15, 6);
        _className = "tank";
    }
    public void SetCaster()
    {
        SetStats(90, 20, 2, 90, 5, 2);
        _className = "caster";
    }
    public void SetStats(int health, int attack, int breakattack, int speed, int defense, int breakbar)
    {
        _totalHealth = health;
        _totalAttack = attack;
        _totalbreakattack = breakattack;
        _totalSpeed = speed;
        _totalDefense = defense;
        _totalBreakbar = breakbar;
    }
}
