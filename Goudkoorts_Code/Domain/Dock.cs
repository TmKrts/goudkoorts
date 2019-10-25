using Goudkoorts_Code.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Dock : BaseRail
    {
        public override bool MoveToThis(Vehicle vehicle)
        {
            if (vehicle.Load == 8) 
            {
                Controller.Score += 10;
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
            return '~';
        }

    }
}
