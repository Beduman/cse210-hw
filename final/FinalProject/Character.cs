using System;

public class Character
{
    protected string _name;
    //total stats
    protected int _totalHealth;
    protected int _totalAttack;
    protected int _totalbreakattack;
    protected int _totalSpeed;
    protected int _totalDefense;
    protected int _totalBreakbar;
    //current stats
    public int _health;
    public int _attack;
    public int _breakattack;
    public int _speed;
    public int _defense;
    public int _breakbar;

    //adding stats
    public int _currentSpeed;

    public Character()
    {

    }
    protected virtual void SetNewClass(int newClass)
    {

    }
    
    protected void SetStats(int health, int attack, int breakattack, int speed, int defense, int breakbar)
    {
        _totalHealth = health;
        _totalAttack = attack;
        _totalbreakattack = breakattack;
        _totalSpeed = speed;
        _totalDefense = defense;
        _totalBreakbar = breakbar;
    }
    public void ResetStats()
    {
        _health = _totalHealth;
        _attack = _totalAttack;
        _breakattack = _totalbreakattack;
        _speed = _totalSpeed;
        _defense = _totalDefense;
        _breakbar = _totalBreakbar;
    }
}
