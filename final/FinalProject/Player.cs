using System;

public class Player
{
    //total stats
    protected int _totalHealth;
    protected int _totalAttack;
    protected int _totalbreakattack;
    protected int _totalSpeed;
    protected int _totalDefense;
    protected int _totalBreak;
    //current stats
    public int _health;
    public int _attack;
    public int _breakattack;
    public int _speed;
    public int _defense;
    public int _break;

    //adding stats
    public int _currentSpeed;

    public string _className;

    public Player(int newClass)
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
        SetStats(90, 40, 1, 100, 50, 2);
        _className = "rogue";
    }
    public void SetBreaker()
    {
        SetStats(110, 10, 3, 80, 60, 4);
        _className = "breaker";
    }
    public void SetTank()
    {
        SetStats(150, 10, 1, 60, 100, 6);
        _className = "tank";
    }
    public void SetCaster()
    {
        SetStats(90, 20, 2, 90, 50, 2);
        _className = "caster";
    }
    public void SetStats(int health, int attack, int breakattack, int speed, int defense, int breakbar)
    {
        _totalHealth = health;
        _totalAttack = attack;
        _totalbreakattack = breakattack;
        _totalSpeed = speed;
        _totalDefense = defense;
        _totalBreak = breakbar;
    }
}
