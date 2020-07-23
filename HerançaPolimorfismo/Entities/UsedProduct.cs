using System;
using System.Globalization;

namespace HerançaPolimorfismo
{
	class UsedProduct : Product
	{
		public DateTime ManufactureDate { get; set; }

		public UsedProduct (string name, double price, DateTime manufactureDate)
			: base (name, price)
		{
			ManufactureDate = manufactureDate;
		}

		public override string priceTag ()
		{
			return Name + "(used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + "Manufacture date: " + ManufactureDate;
		}
	}
}

