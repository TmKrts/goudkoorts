using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class WareHouse : BaseRail
    {
        public override bool MoveToThis(Vehicle vehicle)
        {
            return false;
        }

        public Vehicle SpawnMineCart()
        {
            if (Vehicle == null)
            {
                Vehicle = new Cart(this);
            }
            return Vehicle;
        }

        public override char Print()
        {
            if (Vehicle == null)
            {
                return 'X';
            }

            return Vehicle.Print();
        }
    }
}
