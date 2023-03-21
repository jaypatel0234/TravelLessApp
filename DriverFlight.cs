using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TravelLess_App.Data
{
    public class DriverFlight
    {
        private const string filepath = @"D:\SAIT\SEM 2\TravelLess_App\TravelLess_App\TravelLess_App\TravelLess_App\Files\flights.csv";
		public static List<Flights> data= new List<Flights>();

		public DriverFlight()
		{
			ReadFlightsData();
		}
		private void ReadFlightsData()
        {
            Flights flight;
            foreach (string lines in File.ReadLines(filepath))
            {
                string[] each = lines.Split(',');
                string flightnumber = each[0];
                string flightname = each[1];
                string departairport = each[2];
                string arriveairport = each[3];
                string day = each[4];
                string time = each[5];
                string seats = each[6];
                string cost = each[7];

                flight = new Flights(flightnumber, flightname, departairport, arriveairport, day, time, seats ,cost);
				data.Add(flight);
            }
        }
		public static List<Flights> GetFlights()
		{ return data; }

	}
}
