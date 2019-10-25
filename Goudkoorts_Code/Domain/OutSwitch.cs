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

        public override void DoSwitch()
        {
            if (Vehicle == null)
            {
                if (Next == _nextUp)
                {
                    Next = _nextDown;
                }
                else
                {
                    Next = _nextUp;
                }
            }
        }

        public override char Print()
        {
            if (Vehicle != null)
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
    }
}
