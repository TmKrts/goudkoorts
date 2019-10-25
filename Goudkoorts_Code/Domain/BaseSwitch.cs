using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    public abstract class BaseSwitch : BaseRail
    {
        public override bool MoveToThis(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                Vehicle = vehicle;
                vehicle.onTrack.Vehicle = null;
                vehicle.onTrack = this;
                return true;
            }
            return false;
        }

        public abstract void DoSwitch();
    }
}
