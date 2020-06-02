using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    enum WEAPONS_TYPE
    {
        BOW,
        FLASK,
        DAGGER,
        SWORD,
        ARROW,
        ICE_ARROW,
        LIGHTNING,
        SPIKE,
        CLAWS,
        FLAME,
    }

    class Weapon
    {
        public int m_iAttackPoints;
        WEAPONS_TYPE myType;

        public Weapon(int p_iAttackPoints, WEAPONS_TYPE type)
        {
            m_iAttackPoints = p_iAttackPoints;
            myType = type;
        }

        public static Weapon operator+(Weapon a, Weapon b)
        {
            if (a.myType == b.myType)
            {
                return new Weapon(a.m_iAttackPoints + b.m_iAttackPoints, a.myType);
            }
            return null;
        }

        public WEAPONS_TYPE getWeaponType()
        {
            return myType;
        }

    }
}
