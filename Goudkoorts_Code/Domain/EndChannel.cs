using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class EndChannel : Channel
    {
        public override bool MoveToThis(Vehicle vehicle)
        {
            vehicle.onTrack.Vehicle = null;
            vehicle.onTrack = null;
            return true;
        }
    }
}
