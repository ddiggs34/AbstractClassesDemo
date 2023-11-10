using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        private string v1;
        private string v2;
        private string v3;

        public Motorcycle(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public bool CaddySeat {  get; set; }
        public bool ComesWithExtraHelmet { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This is a virtual method for Motocycle");
        }
    }
}
