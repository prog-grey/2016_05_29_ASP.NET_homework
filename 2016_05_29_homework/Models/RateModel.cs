using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2016_05_29_homework.Models
{

	public class Rate {
		public string RateName { get; set; }
		public double RateBuy { get; set; }
		public double RateSale { get; set; }

		public Rate(string nameRate, double rateBuy, double rateSale) {
			RateName = nameRate;
			RateBuy = rateBuy;
			RateSale = rateSale;
		}
	}

	public class RateModel
	{
		private List<Rate> rateList;
		
		public RateModel() {
			rateList = new List<Rate>();
			rateList.Add(new Rate("USD", 24.85, 25.05));
			rateList.Add(new Rate("EUR", 28.10, 28.41));
			rateList.Add(new Rate("RUS", 0.37, 0.38));
		} 

		public List<Rate> getRateList() {
			return rateList;
		}
		 
	}
	
}