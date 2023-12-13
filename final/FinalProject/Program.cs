using System;

class Program
{
    static void Main(string[] args)
    {
        
        string userInput;
        int userInt = 2;
        Player enemy1 = new Player(userInt);
        Player enemy2 = new Player(userInt);
        Player enemy3 = new Player(userInt);
        Console.WriteLine("Welcome to the turnbased test.");
        Console.WriteLine("This is testing through a console on whether or not combat is fun!");
        Console.ReadLine();
        Console.WriteLine("First we need to get your stats, so you'll need to choose a class for 3 party members");
        Console.WriteLine("Assassin, Breaker, Tank, or Caster");
        Console.WriteLine("An assassin is about dealing damage");
        Console.WriteLine("A breaker is about destroying armor");
        Console.WriteLine("A tank is about taking hits without falling");
        Console.WriteLine("1. Assassin");
        Console.WriteLine("2. Braker");
        Console.WriteLine("3. Tank");
        Console.WriteLine("4. Caster");
        userInput = Console.ReadLine();
        userInt = int.Parse(userInput);
        Player player1 = new Player(userInt);

        Console.WriteLine("This is for player 2");
        Console.WriteLine("1. Rogue");
        Console.WriteLine("2. Braker");
        Console.WriteLine("3. Tank");
        Console.WriteLine("4. Caster");
        userInput = Console.ReadLine();
        userInt = int.Parse(userInput);
        Player player2 = new Player(userInt);

        Console.WriteLine("This is for player 3");
        Console.WriteLine("1. Rogue");
        Console.WriteLine("2. Braker");
        Console.WriteLine("3. Tank");
        Console.WriteLine("4. Caster");
        userInput = Console.ReadLine();
        userInt = int.Parse(userInput);
        Player player3 = new Player(userInt);

        Console.WriteLine("Now it's time for combat, you'll be up against 3 breakers");
        MultiCombat combat1 = new MultiCombat(player1, player2, player3, enemy1, enemy2, enemy3);

        combat1.Run();

    }
}