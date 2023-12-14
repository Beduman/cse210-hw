public class SingleCombat : Combat
{
    Player _player1 = new Player();
    Enemy _enemy1 = new Enemy();
    public SingleCombat(Player player, Enemy enemy) : base()
    {
        _player1 = player;
        _enemy1 = enemy;

    }
    
    void Run()
    {
        Console.WriteLine("Welcome to combat");
        //current stat update
        _player1.ResetStats();
        _enemy1.ResetStats();


        while (_enemy1._health <= 0 || _player1._health <= 0)
        {
            CombatRotation();
        }

    }
    void CombatRotation()
    {
        _player1._currentSpeed = _player1._currentSpeed + _player1._speed;
        _enemy1._currentSpeed = _enemy1._currentSpeed + _enemy1._speed;
        if (_player1._currentSpeed > _enemy1._currentSpeed)
        {
            CombatTurn();
        }
        else
        {
            EnemyTurn();
        }
    }

    void CombatTurn()
    {
        string userInput;
        Console.WriteLine("1. attack");
        Console.WriteLine("2. Break");
        Console.WriteLine("3. Block");
        userInput = Console.ReadLine();

        if (userInput == "1")
        {
            int damageDealt = _player1._attack - _enemy1._defense;
            _enemy1._health -= (_player1._attack - _enemy1._defense);
            Console.WriteLine("You attack the enemy dealing " +damageDealt+ " damage!");
            _player1._currentSpeed = _player1._currentSpeed - 90;
        }

    }
    void EnemyTurn()
    {
        int damageDealt = _enemy1._attack - _player1._defense;
        _player1._health -= (_enemy1._attack - _player1._defense);
        Console.WriteLine("The enemy attacks you and you take "+damageDealt+" damage");
        _enemy1._currentSpeed = _enemy1._currentSpeed - 90;
    }
}