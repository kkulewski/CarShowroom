using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarShowroom.Models
{
	[DisplayName("Sprzedaż")]
	public class Purchase
	{
		public int PurchaseId { get; set; }
		[DisplayName("Klient")]
		public int ClientId { get; set; }
		[DisplayName("Pracownik")]
		public int WorkerId { get; set; }
		[DisplayName("Samochód")]
		public int CarId { get; set; }
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
		[DisplayName("Data")]
		[DataType(DataType.Date, ErrorMessage = "Wartość musi być datą")]
		public DateTime TransactionDate { get; set; }

		public virtual Client Client { get; set; }
		public virtual Worker Worker { get; set; }
		public virtual Car Car { get; set; }
	}
}