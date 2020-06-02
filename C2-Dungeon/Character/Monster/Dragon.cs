using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Dragon : Monster
    {
        public Dragon()
        {
            monster_type = MONSTERS_TYPE.DRAGON;

        }

        public override void Attack(Character character)
        {
            //throw new NotImplementedException();
        }

        public override void RemoveLifePoints()
        {
            //throw new NotImplementedException();
        }
    }
}
