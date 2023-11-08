using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        /*
             * Create an abstract class called Vehicle - done
             * The vehicle class shall have three string properties Year, Make, and Model - done
             * Set the defaults to something generic in the Vehicle class - done 
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

        public string Year { get; set; } = "1990";
        public string Make { get; set; } = "Blank Make";
        public string Model { get; set; } = "Blank Model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Virtual from separate vehicle class");
        }
            

        
       
    }


}



