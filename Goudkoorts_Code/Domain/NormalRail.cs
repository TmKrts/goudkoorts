using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class NormalRail : BaseRail
    {
        public override char Print()
        {
            if(Vehicle == null)
            {
                return '=';
            }
            return Vehicle.Print();
        }
    }
}
