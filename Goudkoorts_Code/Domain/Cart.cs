using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Cart : Vehicle
    {
        public Cart(BaseRail baseRail)
        {
            onTrack = baseRail;
            Load = 1;
        }

        public override bool Move()
        {
            if (onTrack.Next == null || onTrack.Next.MoveToThis(this))
            {
                return true;
            }
            return false;
        }
        public override char Print()
        {
            if (Load == 0)
            {
                return 'o';
            }
            return 'ø';
        }
    }
}
