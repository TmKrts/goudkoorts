using Goudkoorts_Code.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Dock : BaseRail
    {
        public override bool MoveToThis(Vehicle movable)
        {
            if (movable.Load > 7)
            {
                Controller.Score += 10;
                Vehicle = movable;
                movable.onTrack.Vehicle = null;
                movable.onTrack = this;
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
