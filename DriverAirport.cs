using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TravelLess_App.Data
{
	public class DriverAirport
	{
		private const string filepath = @"D:\SAIT\SEM 2\TravelLess_App\TravelLess_App\TravelLess_App\TravelLess_App\Files\airports.csv";
		public static List<Airports> data = new List<Airports>();

		public DriverAirport()
		{
			ReadAirportsData();
		}

		public void ReadAirportsData()
		{
			Airports air;
			foreach (string lines in File.ReadAllLines(filepath))
			{
				string[] each = lines.Split(',');
				string code = each[0];
				string airportname = each[1];
				air = new Airports(code, airportname);
				data.Add(air);
			}
		}
		public static List<Airports> GetAirports()
		{
			return data;
		}
	}
}
