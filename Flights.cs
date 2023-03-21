using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
    public class Flights
    {
        public string FlightNumber { get; set; }
        public string FlightName { get; set; }
        public string DepartAirport { get; set; }
        public string ArriveAirport { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Seats { get; set; }
        public string Cost { get; set; }

        public Flights(string flightNumber, string flightName, string departAirport, string arriveAirport, string day, string time, string seats, string cost)
        {
            this.FlightNumber = flightNumber;
            this.FlightName = flightName;
            this.DepartAirport = departAirport;
            this.ArriveAirport = arriveAirport;
            this.Day = day;
            this.Time = time;
			this.Seats = seats;
			this.Cost = cost;
            
        }

    }
}
