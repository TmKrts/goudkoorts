using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Channel_Piece : BaseRail
    {
        public override bool MoveToThis(Vehicle movable)
        {
            if (Vehicle == null)
            {
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
            return '~';
        }
    }
}
