using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    public class Space : BaseRail
    {
        public override bool MoveToThis(Vehicle vehicle)
        {
            return false;
        }

        public override char Print()
        {
            return ' ';
        }
    }
}
