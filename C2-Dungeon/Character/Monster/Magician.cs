using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace C2_Dungeon
{

    class Magician : Monster
    {

        public Magician()
        {
            m_Weapon = new Weapon(10, WEAPONS_TYPE.LIGHTNING);
            monster_type = MONSTERS_TYPE.MAGICIAN;

        }

        public override void Attack(Character character)
        {
            AttackLightning();
            base.Attack(character);
        }

        public override void RemoveLifePoints()
        {
            //throw new NotImplementedException();
        }

        public void AttackLightning()
        {
            UserInterface.DisplayInfo(false, "sdiufhvweijfnv ");
        }
    }
}
