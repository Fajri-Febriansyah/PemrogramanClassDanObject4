using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman_class_dan_object_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            taxi taxi  = new taxi();

            taxi.DriverName = " QOSIM QODIR BIN AHMAD AL HAMZAH ";
            taxi.OnDuty = true;
            taxi.NumPassenger = 3;

            taxi.taxiinfo();
            taxi.PickUpPassenger();
            taxi.PickDownPassenger();

            Console.ReadKey();
        }
    }
}
