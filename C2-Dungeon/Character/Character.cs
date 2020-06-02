using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    abstract class Character
    {
        protected int m_iHealthPoints;

        protected Weapon m_Weapon;

        protected bool m_bIsDead;

        public Character(int p_iHealthPoints)
        {
            m_iHealthPoints = p_iHealthPoints;

            m_bIsDead = false;

            //m_Weapon = new Weapon(m_AtkPoint);

        }

        abstract public void Attack(Character character);


        abstract public void RemoveLifePoints();

    }
}
