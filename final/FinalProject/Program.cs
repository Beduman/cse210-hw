using System;

class Program
{
    static void Main(string[] args)
    {
        
        string userInput;
        int userInt = 2;
        Enemy enemy1 = new Enemy(1);
        Enemy enemy2 = new Enemy(2);
        Enemy enemy3 = new Enemy(3);
        Console.WriteLine("Welcome to the turnbased test.");
        Console.WriteLine("This is testing through a console on whether or not combat is fun!");
        Console.ReadLine();
        Console.WriteLine("First we need to get your stats, so you'll need to choose a class for 3 party members");
        Console.WriteLine("Assassin, Breaker, Tank, or Caster");
        Console.WriteLine("An assassin is about dealing damage");
        Console.WriteLine("A breaker is about destroying armor");
        Console.WriteLine("A tank is about taking hits without falling");
        Console.WriteLine("1. Assassin");
        Console.WriteLine("2. Breaker");
        Console.WriteLine("3. Tank");
        Console.WriteLine("4. Caster");
        userInput = Console.ReadLine();
        userInt = int.Parse(userInput);
        Player player1 = new Player(userInt);

        Console.WriteLine("This is for player 2");
        Console.WriteLine("1. Rogue");
        Console.WriteLine("2. Breaker");
        Console.WriteLine("3. Tank");
        Console.WriteLine("4. Caster");
        userInput = Console.ReadLine();
        userInt = int.Parse(userInput);
        Player player2 = new Player(userInt);

        Console.WriteLine("This is for player 3");
        Console.WriteLine("1. Rogue");
        Console.WriteLine("2. Breaker");
        Console.WriteLine("3. Tank");
        Console.WriteLine("4. Caster");
        userInput = Console.ReadLine();
        userInt = int.Parse(userInput);
        Player player3 = new Player(userInt);

        SingleCombat combat1 = new SingleCombat();
        combat1.SetCharacters(player1, enemy1);
        combat1.Run();

        Console.WriteLine("Now it's time for combat with all players");
        MultiCombat combat2 = new MultiCombat(player1, player2, player3, enemy1, enemy2, enemy3);

        combat2.Run();

    }
}