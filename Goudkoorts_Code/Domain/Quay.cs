using Goudkoorts_Code.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Quay : BaseRail
    {
        public Dock Dock
        {
            get;
            set;
        }

        public override bool MoveToThis(Vehicle movable)
        {
            if (Vehicle == null)
            {
                if (Dock.Vehicle != null)
                {
                    Dock.Vehicle.Load++;
                    movable.Load--;
                    Controller.Score++;
                }

                Vehicle = movable;
                movable.onTrack.Vehicle = null;
                movable.onTrack = this;
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
