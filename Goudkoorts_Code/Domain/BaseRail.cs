﻿using System;
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
    }
}