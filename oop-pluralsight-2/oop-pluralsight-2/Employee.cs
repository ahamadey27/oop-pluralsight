using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pluralsight_2
{
    //example of basic oop
    public class Employee
    {
        public Employee() //class
        {

        }

        //fields - variables defined from the class level to instantiate employee objects (usually private)
        private string firstName;
        private int age; 

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public void PerformWork()
        {
            //method implementation goes here
        }
    }
}
