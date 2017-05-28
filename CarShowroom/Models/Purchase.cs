using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowroom.Models
{
	public class Purchase
	{
		public int PurchaseId { get; set; }
		public int ClientId { get; set; }
		public int WorkerId { get; set; }
		public int CarId { get; set; }
		public DateTime TransactionDate { get; set; }

		public virtual Client Client { get; set; }
		public virtual Worker Worker { get; set; }
		public virtual Car Car { get; set; }
	}
}