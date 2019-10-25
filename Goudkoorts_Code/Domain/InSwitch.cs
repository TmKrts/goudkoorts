using System;
using System.Collections.Generic;
using System.Linq;
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
            if (Vehicle != null)
            {
                return Vehicle.Print();
            }
            if (Previous == _previousDown)
            {
                return '╔';
            }
            if (Previous == _previousUp)
            {
                return '╚';
            }
            return 'Q';
        }

        public override void DoSwitch()
        {
            if (Vehicle == null)
            {
                if (Previous == _previousUp)
                {
                    _previousUp.Next = null;
                    _previousDown.Next = this;
                    Previous = _previousDown;
                }
                else
                {
                    _previousDown.Next = null;
                    _previousUp.Next = this;
                    Previous = _previousUp;
                }
            }            
        }
    }
}
