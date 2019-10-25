using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    public abstract class BaseRail
    {
        public virtual BaseRail Next
        {
            get;
            set;
        }

        public Vehicle Vehicle 
        { 
            get; 
            set; 
        }

        public abstract char Print();

        public virtual bool MoveToThis(Vehicle vehicle)
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
    }
}
