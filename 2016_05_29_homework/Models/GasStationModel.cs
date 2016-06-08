using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2016_05_29_homework.Models
{
	public class GasStationModel
	{
		public double Count { get; set; }
		public double Price { get; set; }
		public double Discount { get; set; }
		public double Total { get; set; }

		public void calculate(double count, double price)
		{
			Count = count;
			Price = price;
			double sum = Count * Price;
			if (sum < 300)
				Discount = sum * 0.02;
			if ((sum >= 300) && (sum < 500))
				Discount = sum * 0.04;
			if (sum >= 500)
				Discount = sum * 0.06;
			Total = sum - Discount;
		}
	}
}