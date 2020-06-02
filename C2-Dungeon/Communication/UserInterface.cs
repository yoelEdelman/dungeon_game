using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class UserInterface
    {
        static public void DisplayInfo(bool debug, params string[] infos)
        {
            if ((Program.DEBUG_MODE && debug) || !debug)
            {
                foreach (var item in infos)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            } 
        }
        public UserInterface()
        {
            
        }
    }
}
