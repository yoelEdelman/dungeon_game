using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Barbarian : Monster
    {
        public Barbarian()
        {
            m_Weapon = new Weapon(10, WEAPONS_TYPE.SWORD);
            monster_type = MONSTERS_TYPE.BARBARIAN;
        }

        public override void Attack(Character character)
        {
            AttackSword();
            base.Attack(character);
        }

        public override void RemoveLifePoints()
        {
            //throw new NotImplementedException();
        }

        private void AttackSword()
        {
            UserInterface.DisplayInfo(false, " La plume plus puissante que l'epee ");

        }
    }
}
