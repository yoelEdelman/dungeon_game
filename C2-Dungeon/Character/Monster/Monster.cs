using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    enum MONSTERS_TYPE
    {
        BARBARIAN,
        MAGICIAN,
        THIEF,
        DRAGON
    }
    abstract class Monster : Character
    {
        protected MONSTERS_TYPE monster_type;

        public Monster() : base(100)
        {

        }

        internal MONSTERS_TYPE getMonsterType()
        {
            return monster_type;
        }

        public override void Attack(Character character)
        {
            Heros m_Heros = (Heros)character;
            UserInterface.DisplayInfo(false, monster_type.ToString(), " Vous attaque avec : ", m_Weapon.getWeaponType().ToString());
            m_Heros.RemoveHealthPoints(30);
        }

        public override void RemoveLifePoints()
        {
            //throw new NotImplementedException();
        }
    }
}
