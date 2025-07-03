using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pluralsight_2
{
    //Example of Encapsulation
    internal class Car
    {
        private int id; //usable from class itself
        private int temperature; //important data hidden so can't be changed
        public int Id //we control how the data changes 
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
       
         
    }
}
