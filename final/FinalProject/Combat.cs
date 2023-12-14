using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Combat
{

    protected int _totalplayerhp;
    protected int _totalenemyhp;

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

        }
        
        public virtual void CombatTurn()
        {

        }
}
