using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class ChannelEnd : BaseRail
    {
        public override BaseRail Next => null;

        public override bool MoveToThis(Vehicle vehicle)
        {
            vehicle.onTrack.Vehicle = null;
            vehicle.onTrack = null;
            return true;
        }

        public override char Print()
        {
            if (Vehicle != null)
            {
                return Vehicle.Print();
            }
            return '~';
        }
    }
}
