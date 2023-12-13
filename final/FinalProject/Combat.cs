using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Combat
{

    protected int _totalplayerhp;
    protected int _totalenemyhp;
    List<Player> _combatRotation;
    public Combat()
    {

    }
        public virtual void Run() 
        {
            while (_totalenemyhp <= 0 || _totalplayerhp <= 0)
            {
                CombatRotation();

            }


        } 

        public virtual void CombatRotation()
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
