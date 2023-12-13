using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class MultiCombat : Combat
{

    private int _totalplayerhp;
    private int _totalenemyhp;
    List<Player> _combatRotation;
    public MultiCombat(Player player1, Player player2, Player player3, Player enemy1, Player enemy2, Player enemy3)
    {
        List<Player> _combatRotation = new List<Player>() { player1, player2, player3, enemy1, enemy2, enemy3 };

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

        void CombatRotation()
        {
            foreach (Player player in _combatRotation)
            {

                if (player._health > 0)
                {
                    _combatRotation.Remove(player);
                }
            }
            _combatRotation.OrderBy(Player => Player._speed);

        }
}
