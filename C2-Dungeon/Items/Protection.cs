using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    enum PROTECTIONS_TYPE
    {
        CAPE,
        PENDENT,
        SHIELD

    }
    class Protection
    {
        int m_iDefensePoints;
        PROTECTIONS_TYPE mType;
        public Protection(int p_iDefensePoints, PROTECTIONS_TYPE type)
        {
            m_iDefensePoints = p_iDefensePoints;
            mType = type;
        }
    }
}
