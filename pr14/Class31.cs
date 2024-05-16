using cl3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl31
{
	class CarManufacturerComparer : IEqualityComparer<Car>
	{
		public bool Equals(Car x, Car y)
		{
			return x.CarManufacturer == y.CarManufacturer;
		}
		public int GetHashCode(Car obj)
		{
			return obj.CarManufacturer.GetHashCode();
		}
	}

}
