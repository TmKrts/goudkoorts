using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class ParkRail : BaseRail
    {
        public override char Print()
        {
            if (Vehicle != null)
            {
                return Vehicle.Print();
            }
            return '-';
        }
    }
}
