using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class OutSwitch : BaseSwitch
    {
        private BaseRail _nextUp;
        private BaseRail _nextDown;

        public OutSwitch(BaseRail nextUp, BaseRail nextDown)
        {
            _nextUp = nextUp;
            _nextDown = nextDown;
        }

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
            return 'o';
        }
    }
}
