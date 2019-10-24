using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class InSwitch : BaseSwitch
    {
        private BaseRail _previousUp;
        private BaseRail _previousDown;

        public BaseRail Previous
        {
            get;
            set;
        }

        public InSwitch(BaseRail previousrailUp, BaseRail previousRailDown)
        {
            _previousUp = previousrailUp;
            _previousDown = previousRailDown;
        }

        public override char Print()
        {
            return 'p';
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
    }
}
