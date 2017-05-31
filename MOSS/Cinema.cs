using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOSS.Interfaces;

namespace MOSS
{
    class Cinema : Interfaces.Seat, Interfaces.session, Interfaces.loc, Interfaces.Day
    {

        private List<string> cinema_location = new List<string>();
        private List<string> session = new List<string>();
        private List<string> sessionDays = new List<string>();
        private int noSeats;
        private int cinema_no;



        int Seat.numberOfSeats
        {
            get
            {
                return noSeats;
            }

            set
            {
                noSeats = 20;
            }
        }

        public List<string> location
        {
            get
            {
                return cinema_location;
            }

            set
            {
                cinema_location = value;
            }
        }

        public List<string> movieSession
        {
            get
            {
                return session;
            }

            set
            {
                session = value;
            }
        }


        public DateTime Today
        {
            get
            {
                return DateTime.Today;
            }
        }

        public void addlocation()
        {
            cinema_location.Add("St Kilda");
            cinema_location.Add("Melbourne CBD");
            cinema_location.Add("Fitzroy");
            cinema_location.Add("Sunshine");
            cinema_location.Add("LilyDale");
        }

        public void addSession()
        {
            session.Add("1. 1st Show 9  : 00 AM");
            session.Add("2. 2nd Show 12 : 00 PM");
            session.Add("3. 3rd Show 3  : 00 PM");
            session.Add("4. 4th Show 6  : 00 PM");
            session.Add("5. 5th Show 9  : 00 PM");
        }


        public void DisplayCinema()
        {

            string loc;
            string mSession;
            Console.WriteLine("*********************** ABC Corporation Cinema Locations ***********************");
            for (int i = 0; i < cinema_location.Count; i++)
            {
                loc = cinema_location[i];
                Console.WriteLine("{0}. {1}",i,loc);

            }
            Console.WriteLine();
            Console.WriteLine("Choose your Cinema By Entering the number -");
            int.TryParse(Console.ReadLine(),out cinema_no);
            

             DateTime day = DateTime.Today;
             Console.WriteLine("{0}", day.ToString("D"));
             Console.WriteLine("{0}",cinema_location[cinema_no]);
            for (int k = 0; k < session.Count; k++)

            {
                mSession = session[k];
                Console.WriteLine("{0} Show", mSession);

            }
            Console.WriteLine();
            
        }
    }
}
