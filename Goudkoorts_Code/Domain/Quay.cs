using Goudkoorts_Code.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Quay : BaseRail
    {
        public Channel Dock
        {
            get;
            set;
        }

        public override bool MoveToThis(Vehicle vehicle)
        {
            if (Vehicle == null)
            {
                if (Dock.Vehicle != null)
                {
                    Dock.Vehicle.Load++;
                    vehicle.Load--;
                    Controller.Score++;
                }
                Vehicle = vehicle;
                vehicle.onTrack.Vehicle = null;
                vehicle.onTrack = this;
                return true;
            }

            return false;
        }

        public override char Print()
        {
            if (Vehicle != null)
            {
                return Vehicle.Print();
            }
            return 'H';
        }
    }
}
