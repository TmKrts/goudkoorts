using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    public abstract class BaseSwitch : BaseRail
    {
        public override abstract bool MoveToThis(Vehicle movable);
        public override abstract char Print();
        public abstract void SwitchSwitch();
    }
}
