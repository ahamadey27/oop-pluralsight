using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pluralsight_2
{
    public class CarPoly
    {
        public virtual void Drive()
        {

        }
    }

    public class ElectricCar : CarPoly
    {
        public override void Drive()
        {
            base.Drive();
        }
    }
}
