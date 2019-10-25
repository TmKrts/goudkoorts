using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class ParkRail : BaseRail
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
            return true;
        }

        public override char Print()
        {
            if (Vehicle != null)
            {
                return Vehicle.Print();
            }
            return '-';
        }
    }
}
