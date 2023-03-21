using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLess_App.Data
{
	public class Airports
	{
		public string Code { get; set; }
		public string AirportName { get; set; }
		public Airports(string code, string airportName)
		{
			this.Code = code;
			this.AirportName = airportName;
		}
	}
}
