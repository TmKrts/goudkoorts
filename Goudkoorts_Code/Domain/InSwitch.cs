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
    }
}
