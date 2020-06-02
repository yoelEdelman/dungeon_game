using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Thief : Monster
    {
        public Thief()
        {
            m_Weapon = new Weapon(10, WEAPONS_TYPE.ARROW);
            monster_type = MONSTERS_TYPE.THIEF;
        }

        public override void Attack(Character character)
        {
            AttackArrow();
            base.Attack(character);
        }

        public override void RemoveLifePoints()
        {
            //throw new NotImplementedException();
        }

        public void AttackArrow()
        {
            UserInterface.DisplayInfo(false, "C plus puissant que C++ ");
        }
    }
}
