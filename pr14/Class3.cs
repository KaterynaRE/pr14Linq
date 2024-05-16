using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl3
{
	public class Car
	{
		public string CarName {  get; set; }
		public string CarManufacturer {  get; set; }
		public DateTime YearGraduation {  get; set; }

		public Car(string CarName, string CarManufacturer, DateTime YearGraduation)
		{
			this.CarName = CarName;
			this.CarManufacturer = CarManufacturer;
			this.YearGraduation = YearGraduation;
		}

		public override string ToString()
		{
			return $"\nCar name: {CarName}, manufacturer: {CarManufacturer}, year graduation: {YearGraduation} ";
		}
	}
}
