using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman_class_dan_object_4
{
    internal class taxi
    {
    public string DriverName { get; set; }
    public bool OnDuty { get; set; }
    public int NumPassenger { get; set; }
 
    public void taxiinfo()
    {
    string status;
        Console.WriteLine( " DRIVER NAME : {0}", DriverName);

    if (OnDuty)
        {
            status = "YES";
        }else{
            status = "NO";
        }
            Console.WriteLine(" CALL OF DUTY : {0}", status);
            Console.WriteLine(" NUMBER OF PASENGGER  : {0} ", NumPassenger);
        }
    public void PickUpPassenger()
        {
            Console.WriteLine("{0} THE DRIVER IS PICKING UP PASSENGERS ", DriverName);
        }
        public void PickDownPassenger()
        {
            Console.WriteLine("{0} THE DRIVER IS DROPPING OFF PASSENGERS ", DriverName);
        }
        
    }
}
