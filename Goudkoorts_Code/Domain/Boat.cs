using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Boat : Vehicle
    {
        public Boat()
        {
            Load = 0;       
        }
        public override bool Move()
        {
            if (onTrack == null || onTrack.Next == null || onTrack.Next.MoveToThis(this))
            {
                return true;
            }
            return true;
        }
        public override char Print()
        {
            if(Load == 0)
            {
                return 'B';
            }
            String printString = "" + load;
            char print = printString[0];
            return print;
        }
    }
}
