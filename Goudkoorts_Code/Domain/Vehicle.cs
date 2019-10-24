using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    public abstract class Vehicle
    {
        public int Load;

        public BaseRail onTrack;

        public abstract char Print();
        public abstract bool Move();
    }
}
