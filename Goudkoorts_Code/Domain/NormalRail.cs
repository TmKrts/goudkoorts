using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class NormalRail : BaseRail
    {
        public override bool MoveToThis(Vehicle vehicle)
        {
            if (Vehicle == null)
            {
                Vehicle = vehicle;
                vehicle.onTrack.Vehicle = null;
                vehicle.onTrack = this;
                return true;
            }
            return false;
        }

        public override char Print()
        {
            if(Vehicle == null)
            {
                return '=';
            }
            return Vehicle.Print();
        }
    }
}
