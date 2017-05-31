using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSS
{
    class DisplayCinemaList 
    {
        

        public static void Main(string[] args)
        {
            Cinema C = new Cinema();
            C.addlocation();
            C.addSession();
            C.DisplayCinema();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
