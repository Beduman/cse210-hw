using System;

public class Character
{
    protected string _name;
    //total stats
    public int _totalHealth;
    public int _totalAttack;
    public int _totalbreakattack;
    public int _totalSpeed;
    public int _totalDefense;
    public int _totalBreak;
    //current stats
    public int _health;
    public int _attack;
    public int _breakattack;
    public int _speed;
    public int _defense;
    public int _break;

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
        _totalBreak = breakbar;
    }
}
