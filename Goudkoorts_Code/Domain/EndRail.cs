using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class EndRail : NormalRail
    {
        public override BaseRail Next => null;

        public override bool MoveToThis(Vehicle vehicle)
        {
            vehicle.onTrack.Vehicle = null;
            return true;
        }
    }
}
