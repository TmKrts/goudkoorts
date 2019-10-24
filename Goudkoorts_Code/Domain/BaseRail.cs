using System;
using System.Collections.Generic;
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

        public abstract bool MoveToThis(Vehicle vehicle);
    }
}
