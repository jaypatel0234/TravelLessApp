using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class Reservations
	{ 
		public string ReservationCode { get; set; }
		public string FlightNumber { get; set; }
		public string FlightName { get; set;}
		public string Cost { get; set; }
		public string FullName { get; set;}	
		public string Citizenship { get; set; }
		public bool Status { get; set; }

		public Reservations(string reservationCode, string flightNumber, string flightName, string cost, string fullName, string citizenship, bool status)
		{
			ReservationCode = reservationCode;
			FlightNumber = flightNumber;
			FlightName = flightName;
			Cost = cost;
			FullName = fullName;
			Citizenship = citizenship;
			Status = status;
		}
	}
}
