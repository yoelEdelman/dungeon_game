using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class DragonsLair : Room
    {
        //Dragon m_Dragon;

        public DragonsLair() : base(new Dragon())
        {
            //m_Dragon = new Dragon();


        }
        internal override void Enter(Heros newHero)
        {
           
        }
    }
}
