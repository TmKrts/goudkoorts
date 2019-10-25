using System;
using System.Collections.Generic;
using System.Linq;
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
            if (Movable != null)
            {
                return Vehicle.Print();
            }
            if (Next == _nextUp)
            {
                return '╝';
            }
            if (Next == _nextDown)
            {
                return '╗';
            }
            return 'S';
        }
        

        public override void DoSwitch()
        {
            if(Vehicle == null) 
            {
                if(Next == _nextUp) 
                {
                    Next = _nextDown;
                }
                else 
                {
                    Next = _nextUp;
                }
            }
        }
    }
}
