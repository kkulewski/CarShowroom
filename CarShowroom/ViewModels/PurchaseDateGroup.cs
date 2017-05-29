using System;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.ViewModels
{
	public class PurchaseDateGroup
	{
		[DataType(DataType.Date)]
		public DateTime? TransactionDate { get; set; }

		public int PurchaseCount { get; set; }
	}
}