using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class MultiCombat : Combat
{


    List<Player> _combatRotation;
    public MultiCombat(Player player1, Player player2, Player player3, Enemy enemy1, Enemy enemy2, Enemy enemy3)
    {
        List<Character> _combatRotation = new List<Character>() { player1, player2, player3, enemy1, enemy2, enemy3 };

        int _totalplayerhp = player1._health + player2._health + player3._health;
        int _totalenemyhp = enemy1._health + enemy2._health + enemy3._health;

    }
        public void Run() 
        {
            while (_totalenemyhp <= 0 || _totalplayerhp <= 0)
            {
                CombatRotation();

            }


        } 

        public void CombatRotation()
        {
            foreach (Player player in _combatRotation)
            {

                if (player._health > 0)
                {
                    Console.WriteLine(player._className + " is knocked out");
                    _combatRotation.Remove(player);
                }
            }
            _combatRotation.OrderBy(Player => Player._speed);

        }

    public void CombatTurn()
    {

    }
    public void EnemyTurn()
    {

    }
}
