using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Heros : Character
    {
        #region VariableInit
            int m_iDefensePoints;
            string m_sName;

            Protection m_Protection;
        #endregion

        #region Constructors
            /// <summary>
            /// Hero Class, required name
            /// </summary>
            /// <param name="p_sName">Hero Name</param>
            /// 
            public Heros(string p_sName) : base(100)
            {
                m_sName = p_sName;
                m_Weapon = new Weapon(10, WEAPONS_TYPE.ARROW);
                /// userInterface.displayInfo(Program.debug, "On est dans le constructeur avec arguments de heros : ", m_sName);
                m_Protection = new Protection(10, PROTECTIONS_TYPE.SHIELD); 
        }

        public override void Attack(Character character)
        {
            Monster m = (Monster)character;
            MONSTERS_TYPE qwerty = m.getMonsterType();
            UserInterface.DisplayInfo(false, " Vous etes en train d'attaquer un  : ", qwerty.ToString());
        }

        public override void RemoveLifePoints()
        {
            //throw new NotImplementedException();
        }

        public void RemoveHealthPoints(int p_iHealthPoints)
        {
            int currentHealthPoints = m_iHealthPoints;
            m_iHealthPoints -= p_iHealthPoints;
            UserInterface.DisplayInfo(false, "You lose : ", p_iHealthPoints.ToString(), " health points !");

            if (m_iHealthPoints < 0)
            {
                DeadSequence();
            }
            else
            {
                UserInterface.DisplayInfo(false, "Passing from : ", currentHealthPoints.ToString(), " health points, to : ", m_iHealthPoints.ToString(), " health points !");
            }
        }

        private void DeadSequence()
        {
            m_bIsDead = true;
            UserInterface.DisplayInfo(false, "Your Dead !");
        }

        //public void FindWeapon(Weapon myWeapon)
        //    {
        //        weapon += myWeapon;
        //    }
        #endregion
    }
}
