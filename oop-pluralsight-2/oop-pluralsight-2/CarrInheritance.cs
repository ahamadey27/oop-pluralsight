using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pluralsight_2
{
    //Inheritance example
    public class CarrInheritance
    {
        private int maxSpeed;
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value };


    }

    public class Convertible : CarrInheritance
    {
        private bool isRoofopen;
    }
}
