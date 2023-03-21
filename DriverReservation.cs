using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	internal class DriverReservation
	{
		private const string filepath = @"D:\SAIT\SEM 2\TravelLess_App\TravelLess_App\TravelLess_App\TravelLess_App\Files\reservations.csv";
		public static List<Reservations> data = new List<Reservations>();
		public DriverReservation()
		{
			ReadReservationsData();
		}

		public void ReadReservationsData()
		{
			Reservations reserve;
			foreach (string lines in File.ReadAllLines(filepath))
			{
				string[] each = lines.Split(',');
				string reservationCode = each[0];
				string flightNumber = each[1];
				string flightName = each[2];
				string cost = each[3];
				string fullName = each[4];
				string citizenship = each[5];
				bool status = bool.TryParse(each[6],out bool result);
				reserve = new Reservations(reservationCode,flightNumber,flightName, cost, fullName, citizenship,status);
				data.Add(reserve);
			}
		}
		public static List<Reservations> GetReservations()
		{
			return data;
		}
	}
}
